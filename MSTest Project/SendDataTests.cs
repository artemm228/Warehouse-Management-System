using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management_System;

namespace MSTest_Project
{
    [TestClass]
    public class SendDataTests
    {
            [TestMethod]
            public async Task TestSendData()
            {
                // Arrange
                string action = "Search";
                string[] args = { "gold" };

                // Creating an instance of the tested class.
                Client_System clientSystem = new Client_System();

                // Act
                string[] result = await clientSystem.SendData(action, args);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(1, result.Length);
                Assert.AreEqual("Name: gold, Description: 15mg gold, Quantity: 2, Price: 43,0000", result[0]);
            }
        
    }
}
