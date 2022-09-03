# CMPG323-Project-2-34292748
## Application Programming Interfaces (APIs) Development

## More about the Project
Now we're more connected that ever, you can purchase anything by your fingertips from desktops, phones etc. But how does data get from here to there, how do devices and applications connect with each other to allow us to place an order, make a reservation or book a flight with just a few things. That's where the Application Programming Interface (API) comes in, it is the engine under the hood and is behind the scenes that we take for granted but its what makes possible all the interactivity we've come to expect and rely upon. An API is the messenger that takes requests and tells a system what you want to do and then returns the response back to you. To make it clearer think of an API as a waiter in a restaurant and imagine you're sitting with a menu of choice to order from, in the kitchen is the part of the system which will prepare your order. What is missing is the communication link between your order and the kitchen that will deliver your food back to your table. That's where the API (waiter) comes in, it is the messenger that takes your request or order and tells the system (kitchen) what to do and delivers the response back to you which is food. 

<img src="/Images/API.png" alt="API">

### API Contract
API Contract is API documentation that informs users on how this API will behave, as well as the endpoint URLs. The API contract contains the activity of each endpoint, sample replies, error information, and any other API-related details. API Contract is published by the service provider for the consumers of the API. The document is usually developer centric. API contract can be created in several formats but the most popular is the Open API specification (formerly known as Swagger).

## Manual
Stakeholders will run the software and navigate to the Swagger UI, where they will find choices such as getting all the items in the database, getting any item by its ID, creating a new item, updating an item, and deleting an item.
To GET any item, you must first POST (create) it because the response body will only include empty parenthesis. To add an item, go to POST and then execute. You will be needed to input an ID and further information before executing. You will be given a code, and next to it will be a response body where you can view what you have generated. You can GET, PATCH, DELETE an item by its ID.

## Phase 1 - GitHub Administration
- Created & Configured my GitHub repository while i'm busy with the training.

## Phase 2 - Data Source: Configure Database
- I've begun with my API source control, and I've already loaded the local database.
- A secure service account username and password have been assigned to the SQL Server on Azure.
- The database on Azure SQL Server has been built, and the script with the necessary tables has been run.

## Phase 2 -Project Setup: API Project
- The ASP.NET Core Web API was created with the 3.1 Framework.
- Installed all the frameworks that were needed in order to run the application.
- Created the necessary Controllers. 
- The database was scaffold - which produces an Entity Framework model from an existing database by input my connection string from Azure.
- I have applied dependency injection that allows me to develop loosely-coupled code.
- Cloned my project to the GitHub repository.

## Phase 3 - Functionality
- Created a new branch so that i can start developing my project and merging it to the main after big changes.
- When i created the Category Controller, i have made one that has actions, using Framework Entity. 
- It already has most of the methods (GET, POST, DELETE etc.)
- After that i created a pushed to my develop branch, and made a pull request to grab the changes that i have made. 
- Seeing that everything is working i created a merge request to my main branch.
- On this Project I am using GitHub Flow, when the code is working properly i create a pull request to the main.

### Methods
Representational State Transfer (REST) is a web service architecture approach. REST queries are sent through HTTP. They employ the same HTTP verbs that web browsers employ to get pages and transfer data to servers.
- GET: Retrieve all data from the database.
- GET: Retrieve data from the database based on the ID entered.
- POST: Create a new item of data on the database.
- PATCH: Update an existing item of data on the database.
- DELETE: Delete an item of data on the database.

## Security
The disadvantage of publicly available web APIs is that they may offer significant danger to API providers. APIs are intended to provide others with access to your data: behind every API is an endpoint—the server (and its accompanying databases) that answers to API queries.  Concerning possible vulnerability A vulnerability is a flaw in a system (hardware or software) that can be exploited by an attacker. Vulnerabilities exist in any system; "zero-day" vulnerabilities are ones that have not yet been identified., an API endpoint is similar to any Internet-facing web server; the higher the public's free and open access to a resource, the greater the potential threat from bad actors.

### Authentication
So i have to authenticate my API so that no malicious code is put into it, so i will be using token based security. When you put the correct credentials a token will be provided to all the services that I will be accessing. So I will add endpoints in my API, whereby you register first then login. Also there will be different roles given (Admin or User). After login in you will get the token whereby you will use to Authorize yourself in a Bearer Authentication, then you can use the API. Only admin pesonnel can access it.


## Reference List
- Zhou, W., Li, L., Luo, M. and Chou, W., 2014, May. REST API design patterns for SDN northbound API. <i> In 2014 28th international conference on advanced information networking and applications workshops </i> (pp. 358-365). IEEE.
- Sohan, S.M., Maurer, F., Anslow, C. and Robillard, M.P., 2017, October. A study of the effectiveness of usage examples in REST API documentation.<i> In 2017 IEEE Symposium on Visual Languages and Human-Centric Computing (VL/HCC)</i>(pp. 53-61). IEEE.
Masse, M., 2011.<i> REST API design rulebook: designing consistent RESTful web service interfaces </i>. " O'Reilly Media, Inc.".
- Soni, A. and Ranga, V., 2019. API features individualizing of web services: REST and SOAP.<i>International Journal of Innovative Technology and Exploring Engineering </i>, 8(9), pp.664-671.
- Mumbaikar, S. and Padiya, P., 2013. Web services based on soap and rest principles.<i> International Journal of Scientific and Research Publications, 3</i>(5), pp.1-4.
- Halili, F. and Ramadani, E., 2018. Web services: a comparison of soap and rest services. <i>Modern Applied Science, 12</i>(3), p.175.
- De, B., 2017. API documentation. <i>In API Management </i>(pp. 59-80). Apress, Berkeley, CA.
- Chadwick, J., Snyder, T. and Panda, H., 2012. <i>Programming ASP. NET MVC 4: Developing Real-World Web Applications with ASP. NET MVC</i>. " O'Reilly Media, Inc.".
- Haunts, S., 2019. Key Storage and Azure Key Vault.<i> In Applied Cryptography in. NET and Azure Key Vault </i>(pp. 143-168). Apress, Berkeley, CA.
- Herath, P., 2022. Working with Azure Key Vault. <i>In Azure Cloud Security for Absolute Beginners</i> (pp. 71-91). Apress, Berkeley, CA.

