using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Server
{
    internal class Server
    {
        private TcpListener listener;
        private bool isRunning;

        static string connectionString;

        static void Main(string[] args)
        {
            // Creating and reading configuration data and connections
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();

            connectionString = config.GetConnectionString("MainConnectionString");


            Server server = new Server();
            server.Start();

            Console.ReadLine();

            server.Stop();
        }

        public Server()
        {
            // It listens for incoming connections on a local address and port
            listener = new TcpListener(IPAddress.Loopback, 1234);
        }

        private async Task ProcessClient(TcpClient client)
        {
            NetworkStream stream = null;

            try
            {
                var buffer = new byte[1024];
                stream = client.GetStream();

                // Reading data from the client
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string requestData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                // Processing the request and getting the answer
                string[] response = await ProcessRequest(requestData);

                // Sending a header with information about the availability of additional data.
                byte[] header = new byte[] { (byte)(response.Length > 1 ? 1 : 0) };
                await stream.WriteAsync(header, 0, header.Length);

                // Sending the response to the client-side.
                byte[] responseBytes = Encoding.ASCII.GetBytes(string.Join("|", response));
                await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Closing the client and the stream
                client?.Close();
                stream?.Close();
            }
        }

        private async Task<string[]> ProcessRequest(string requestData)
        {
            // Dividing data into action and arguments
            string[] requestParts = requestData.Split('|');
            string action = requestParts[0];
            string[] args = new string[requestParts.Length - 1];
            Array.Copy(requestParts, 1, args, 0, args.Length);

            // Interaction with the database
            var optionsBuilder = new DbContextOptionsBuilder<ServerDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            using (var dbContext = new ServerDbContext(optionsBuilder.Options))
                if (action == "Add")
                {
                    // The logic of adding a record to the database

                    await dbContext.SaveChangesAsync();
                    return new string[] { "Success" };
                }
                else if (action == "Edit")
                {
                    // The logic of editing a record in a database.

                    await dbContext.SaveChangesAsync();
                    return new string[] { "Success" };
                }
                else if (action == "Delete")
                {
                    // The logic of deleting a record from a database.

                    await dbContext.SaveChangesAsync();
                    return new string[] { "Success!" };
                }
                else
                {
                    return new string[] { "Invalid action" };
                }
        }

        public void Start()
        {
            isRunning = true;
            listener.Start(); // starts listening for incoming connections
            Console.WriteLine("Server started");

            while (isRunning)
            {
                var client = listener.AcceptTcpClient(); // The client connection is expected.
                _ = ProcessClient(client); // The connected client is saved in the variable 'client'
            }
        }

        public void Stop()
        {
            isRunning = false;
            listener.Stop(); // it stops accepting new connections
            Console.WriteLine("Server stopped.");
        }
    }
}


