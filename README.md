## Warehouse-Management-System

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![Google Chrome](https://img.shields.io/badge/Google%20Chrome-4285F4?style=for-the-badge&logo=GoogleChrome&logoColor=white) ![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white) ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white) ![Microsoft](https://img.shields.io/badge/Microsoft-0078D4?style=for-the-badge&logo=microsoft&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)





### Explanation
The SendData method is responsible for sending requests to the server and receiving responses from it. It accepts an action and arguments, sends them to the server through a TCP connection, and then processes the received response.

The DeleteData, AddData, and EditData methods of the Form_Management class are responsible for deleting, adding, and editing product data. They validate and verify the input data, send requests to the server, and process the received responses.

The advantage of client-server interaction lies in the distribution of work between the client and the server. The client sends requests, and the server performs the logic and interacts with the database. This allows for separation of responsibilities and ensures scalability and flexibility of the system.

If all the server logic were included with the project, including the interface, it would complicate the support and development of the application. It would be difficult to scale and modify the code, as well as reuse it in other projects. Separating the client and server allows for better code organization and easier maintenance and expansion of functionality.

When a button is clicked, it is placed in a new thread. This allows operations to be executed in the background, so they do not block the user interface and provide responsiveness to the application. Separate threads for each button divide the work and allow for simultaneous execution of different operations without blocking each other. This improves performance and enhances interface responsiveness.

1. The ProcessLogin method handles a request for user authentication. It checks if the user exists in the database with the given login and password. If the user is found, a successful response of "Success" is returned, otherwise "Invalid" is returned.

2. The ProcessRegistration method handles a request to register a new user. It checks if a user with the same login already exists and, if not, adds the new user to the database. The corresponding response indicating the success of the operation is returned.

3. The ProcessSearchByName method handles a request to search for products by name. It executes an SQL query to the database to find products whose name contains the specified search string. The search results are returned as an array of strings containing information about the found products.

4. The ProcessClient method handles each client connection. It reads data from the client, processes the request, forms a response, and sends it back to the client. This method is handled in a separate thread for each client, allowing the server to handle multiple clients in parallel.

5. The ProcessRequest method is the core part of the server. It receives a request from the client and determines which action needs to be performed. Depending on the action, it calls the corresponding methods to handle the request (e.g. adding, editing, or deleting product data) and returns the appropriate response.

6. The AcceptClients method is the entry point for the server. It starts listening for incoming connections and when a new client is accepted, it starts processing its connection in a separate thread. This method works in a loop, waiting for new clients to arrive.

The SendDataTests class in the MSTest_Project project represents a set of test methods for verifying the functionality of the SendData method in the Client_System class.
