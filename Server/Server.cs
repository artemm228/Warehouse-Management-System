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
using System.Data.SqlClient;
using System.Data;

namespace Server
{
    public class Server
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
            Task.Run(() => server.AcceptClients()).Wait();
        }

        public async Task<string[]> ProcessLogin(string username, string password)
        {
            string[] response;

            try
            {
                // Checking for the presence of a user in the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = "SELECT COUNT(1) FROM Users WHERE [Login] = @Username AND [Password] = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int result = (int)await command.ExecuteScalarAsync();

                        if (result == 1)
                        {
                            response = new string[] { "Success" };
                        }
                        else
                        {
                            response = new string[] { "Invalid" };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = new string[] { "Error", ex.Message };
            }

            return response;
        }

        private async Task<string[]> ProcessRegistration(string firstName, string lastName, string login, string password, int isroot)
        {
            string[] response;

            try
            {  
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Checking if a user with such a login already exists.
                    string checkQuery = "SELECT COUNT(1) FROM Users WHERE [Login] = @Login";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Login", login);

                        int count = (int)await checkCommand.ExecuteScalarAsync();

                        // If a user with such a username already exists, return an error
                        if (count > 0)
                        {
                            response = new string[] { "Duplicate" };
                            return response;
                        }
                    }

                    // Adding a new user to the database
                    string insertQuery = @"INSERT INTO Users ([Login], [Password], [FirstName], [LastName], [isRoot]) 
                                          VALUES (@Login, @Password, @FirstName, @LastName, @isRoot)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Login", login);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                        insertCommand.Parameters.AddWithValue("@LastName", lastName);
                        insertCommand.Parameters.AddWithValue("@isRoot", isroot);

                        int rowsAffected = await insertCommand.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            response = new string[] { "Success" };
                        }
                        else
                        {
                            response = new string[] { "Failed" };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = new string[] { "Error", ex.Message };
            }

            return response;
        }

        private async Task<string[]> ProcessSearchByName(string search)
        {
            string[] response;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Adding a new user to the database
                    string query = "SELECT [Name], [Description], [QuantityOfGoods], [Price] FROM Item WHERE [Name] LIKE '%' + @Search + '%'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Search", search);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            var results = new List<string>();

                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string description = reader.GetString(1);
                                int quantity = reader.GetInt32(2);
                                decimal price = reader.GetDecimal(3);

                                string result = $"Name: {name}, Description: {description}, Quantity: {quantity}, Price: {price}";
                                results.Add(result);
                            }

                            response = results.ToArray();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = new string[] { "Error", ex.Message };
            }

            return response;
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

            if (action == "Add")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string addquery = $@"INSERT INTO Item (Name, Description, QuantityOfGoods, Price) VALUES (@Name, @Description, @QuantityOfGoods, @Price)";
                    using (SqlCommand command = new SqlCommand(addquery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", args[0]);
                        command.Parameters.AddWithValue("@Description", args[1]);
                        command.Parameters.AddWithValue("@QuantityOfGoods", int.Parse(args[2]));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(args[3]));

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                            return new string[] { "Insert successful!" };
                        else
                            return new string[] { "Insert failed" };
                    }
                }
            }
            else if (action == "Edit")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string updateQuery = "UPDATE Item SET ";
                    bool hasUpdate = false;

                    if (!string.IsNullOrWhiteSpace(args[1]))
                    {
                        updateQuery += "Description = @NewDescription, ";
                        hasUpdate = true;
                    }

                    if (!string.IsNullOrWhiteSpace(args[2]) && int.TryParse(args[2], out int newQuantity))
                    {
                        updateQuery += "QuantityOfGoods = @NewQuantity, ";
                        hasUpdate = true;
                    }

                    if (!string.IsNullOrWhiteSpace(args[3]) && decimal.TryParse(args[3], out decimal newPrice))
                    {
                        updateQuery += "Price = @NewPrice, ";
                        hasUpdate = true;
                    }

                    if (!hasUpdate)
                    {
                        return new string[] { "No fields to update." };
                    }

                    updateQuery = updateQuery.Remove(updateQuery.Length - 2);

                    updateQuery += " WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", args[0]);

                        if (!string.IsNullOrWhiteSpace(args[1]))
                        {
                            command.Parameters.AddWithValue("@NewDescription", args[1]);
                        }

                        if (!string.IsNullOrWhiteSpace(args[2]) && int.TryParse(args[2], out int newQuantityParsed))
                        {
                            command.Parameters.AddWithValue("@NewQuantity", newQuantityParsed);
                        }

                        if (!string.IsNullOrWhiteSpace(args[3]) && decimal.TryParse(args[3], out decimal newPriceParsed))
                        {
                            command.Parameters.AddWithValue("@NewPrice", newPriceParsed);
                        }

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            return new string[] { "Update successful!" };
                        }
                        else
                        {
                            return new string[] { "No rows updated" };
                        }
                    }
                }
            }
            else if (action == "Delete")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string deletequery = "DELETE FROM Item WHERE Name = @Name";
                    using (SqlCommand command = new SqlCommand(deletequery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", args[0]);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                            return new string[] { "Delete Success!" };
                        else
                            return new string[] { "No rows deleted" };

                    }
                }
            }
            else if (action == "Login")
            {
                    // Get the login and password from the arguments
                    string username = args[0];
                    string password = args[1];

                    // pass the login and password to the processlogin method for verification
                    return await ProcessLogin(username, password);
            }
            else if (action == "Registration")
            {
                //  obtain registration data from the arguments
                string firstName = args[0];
                string lastName = args[1];
                string login = args[2];
                string password = args[3];
                string isroot = args[4];

                // call a method for processing registration and receiving a response
                return await ProcessRegistration(firstName, lastName, login, password, int.Parse(isroot));
            }
            else if (action == "Search")
            {
                string search = args[0];

                return await ProcessSearchByName(search);
            }
            else
            {
                return new string[] { "Invalid action" };
            }
        }

        public async Task AcceptClients()
        {
            isRunning = true;
            listener = new TcpListener(IPAddress.Loopback, 1234);

            try
            {
                listener.Start();
                Console.WriteLine("Server started. Listening for incoming connections...");

                while (isRunning)
                {
                    try
                    {
                        TcpClient client = await listener.AcceptTcpClientAsync();
                        Console.WriteLine("New client connected.");

                        // Process each client connection in a separate thread
                        _ = Task.Run(() => ProcessClient(client));
                    }
                    catch (Exception ex)
                    {
                        // Handling an error when accepting a client
                        Console.WriteLine($"Error accepting client: {ex.Message}");   
                    }
                }
            }
            finally
            {
                listener.Stop();
                Console.WriteLine("Server stopped.");
                isRunning = false;
            }
        }
    }
}


