using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_System
{
    public class Client_System
    {
        // Method for sending data to the server and receiving a response
        public async Task<string[]> SendData(string action, params string[] args)
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                string dataToSend = $"{action}|{string.Join("|", args)}";

                // Creating a TCP client and connecting to the server
                using (client = new TcpClient("localhost", 1234))
                {
                    var bytes = Encoding.ASCII.GetBytes(dataToSend);
                    stream = client.GetStream();

                    // Sending data to the server
                    await stream.WriteAsync(bytes, 0, bytes.Length);

                    // Getting the header from the server
                    bytes = new byte[1];
                    await stream.ReadAsync(bytes, 0, 1);
                    bool hasAdditionalData = Convert.ToBoolean(bytes[0]);

                    // Receiving a response from the server
                    bytes = new byte[1024];
                    StringBuilder response = new StringBuilder();

                    int bytesRead;
                    while ((bytesRead = await stream.ReadAsync(bytes, 0, bytes.Length)) != 0)
                    {
                        response.Append(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                    }

                    string responseMessage = response.ToString();

                    // Processing response from the server
                    if (hasAdditionalData)
                    {
                        // if the answer contains additional data
                        string[] responseParts = responseMessage.Split('|');
                        string[] responseData = new string[responseParts.Length - 1];
                        Array.Copy(responseParts, 1, responseData, 0, responseData.Length);

                        return responseData;
                    }
                    else
                    {
                        return new string[] { responseMessage };
                    }
                }
            }
            catch (Exception ex)
            {
                return new string[] { ex.Message };
            }
            finally
            {
                client?.Close();
                stream?.Close();
            }
        }
    }
}
