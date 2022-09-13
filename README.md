# CMPG323-Project-2-34292748
## Application Programming Interfaces (APIs) Development

## More about the Project
Now we're more connected than ever, you can purchase anything with your fingertips from desktops, phones, etc. But how does data get from here to there, how do devices and applications connect to allow us to place an order, make a reservation or book a flight with just a few things. That's where the Application Programming Interface (API) comes in, it is the engine under the hood and is behind the scenes that we take for granted but it's what makes possible all the interactivity we've come to expect and rely upon. An API is a messenger that takes requests and tells a system what you want to do and then returns the response to you. To make it clearer think of an API as a waiter in a restaurant and imagine you're sitting with a menu of choice to order from, in the kitchen is the part of the system which will prepare your order. What is missing is the communication link between your order and the kitchen that will deliver your food back to your table. That's where the API (waiter) comes in, it is the messenger that takes your request or order and tells the system (kitchen) what to do, and delivers the response back to you which is food.

<img src="/Images/API.png" alt="API">


## Manual for the API
- Stakeholders will be able to use the API from Azure or they can download the code from my GitHub repository and execute it from Visual Studio.
- When they execute it, it will lead them to the Swagger UI. Swagger UI is used to provide interactive API documentation that allows your users to test API calls in the browser.
- Whereby they must register before utilizing it. They can sign up as either an administrator or a user.
- When you are an Admin, you can CREATE, GET, DELETE, and so on.
- You can either utilize the Categories, Device and Zone Controllers.
- When you register, you must provide your username, email address, and password.
- After login, you will receive an authentication token, which will be used to authorize you to utilize all API functions.
- There are options for collecting all the items in the database, retrieving any item by its ID, adding a new item, changing an item, removing an item and so on.
- To GET any item, you must first POST (create) it since you will get empty parenthesis if you did not enter anything.
- You can delete or alter an item based on its ID.

### Credentials to use:
- Alternatively you can go to swagger using the following: <a href= "https://asecmpg323-project-2-34292748.azurewebsites.net/swagger/index.html">SwaggerUI</a></li>



| Role          | Administrator   | User |
| :------------ |:---------------:| :-----:|
| Username      | John            | Jane |
| Password      | cMPG323!        | CMPg323! |


## Phase 1 - GitHub Administration
- While I'm in training, I've created and configured my GitHub repository.

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

## Phase 3 - Functionality of Controllers
- I created a new branch called develop to begin building my project and merging it to the main after significant modifications.
- When When I constructed the Controllers, I used Framework Entity to build one with actions.
- It already has the majority of the methods (GET, POST, DELETE etc.)
- I then issued a push to my develop branch and a pull request to retrieve the modifications that I had done.
- After seeing that everything was operating well, I created a merge request to my main branch.
- On this project, I'm using GitHub Flow, and when the code is complete, I make a pull request to the main.

### Methods
The methods that are used in my API are the following: 
- GET: Retrieve all data from the database.
- GET: Retrieve data from the database based on the ID entered.
- GET: Retrieve all devices within a specific zone.
- GET: Retrieve all devices within a specific category
- GET: Return the number of zones that are associated to a specific category.
- POST: Create a new item of data on the database.
- PATCH: Update an existing item of data on the database.
- DELETE: Delete an item of data on the database.

## Security
The disadvantage of publicly available web APIs is that they may offer a significant danger to API providers. APIs are intended to provide others with access to your data: behind every API is an endpoint—the server (and its accompanying databases) that answers API queries.  Concerning possible vulnerability, A vulnerability is a flaw in a system (hardware or software) that can be exploited by an attacker. Vulnerabilities exist in any system; "zero-day" vulnerabilities have not yet been identified. An API endpoint is similar to any Internet-facing web server; the higher the public's free and open access to a resource, the greater the potential threat from bad actors.

## Credentials
When it comes to storing my credentials, i have masked my connection string to "DefaultString" since it has sensitive information. The original connection string is in the appsettings.json. Which will be gitignored to prevent my credentials from being shown.

### Authentication 
So I have to authenticate my API so that no malicious code is put into it, so I will be using token-based security. When you put the correct credentials a token will be provided to all the services that I will be accessing. So I will add endpoints in my API, whereby you register first and then log in. Also, there will be different roles given (Admin or User). After login in you will get the token whereby you will use to Authorize yourself in a Bearer Authentication, then you can use the API. Only admin personnel can access all of the API functions, when you are a user and you want to add any item you will get an error. I authenticated all of my controllers (Category, Device, Zone)

## API Manager Endpoints
<img src="/Images/API Manager.png" alt="API">

## Reference List
- Zhou, W., Li, L., Luo, M. and Chou, W., 2014, May. REST API design patterns for SDN northbound API. <i> In 2014 28th international conference on advanced information networking and applications workshops </i> (pp. 358-365). IEEE.
- Sohan, S.M., Maurer, F., Anslow, C. and Robillard, M.P., 2017, October. A study of the effectiveness of usage examples in REST API documentation.<i> In 2017 IEEE Symposium on Visual Languages and Human-Centric Computing (VL/HCC)</i>(pp. 53-61). IEEE.
- Masse, M., 2011.<i> REST API design rulebook: designing consistent RESTful web service interfaces </i>. " O'Reilly Media, Inc.".
- Soni, A. and Ranga, V., 2019. API features individualizing of web services: REST and SOAP.<i>International Journal of Innovative Technology and Exploring Engineering </i>, 8(9), pp.664-671.
- Mumbaikar, S. and Padiya, P., 2013. Web services based on soap and rest principles.<i> International Journal of Scientific and Research Publications, 3</i>(5), pp.1-4.
- Halili, F. and Ramadani, E., 2018. Web services: a comparison of soap and rest services. <i>Modern Applied Science, 12</i>(3), p.175.
- De, B., 2017. API documentation. <i>In API Management </i>(pp. 59-80). Apress, Berkeley, CA.
- Chadwick, J., Snyder, T. and Panda, H., 2012. <i>Programming ASP. NET MVC 4: Developing Real-World Web Applications with ASP. NET MVC</i>. " O'Reilly Media, Inc.".
- Haunts, S., 2019. Key Storage and Azure Key Vault.<i> In Applied Cryptography in. NET and Azure Key Vault </i>(pp. 143-168). Apress, Berkeley, CA.
- Herath, P., 2022. Working with Azure Key Vault. <i>In Azure Cloud Security for Absolute Beginners</i> (pp. 71-91). Apress, Berkeley, CA.
- MuleSoft Videos. (2015, Jun 20). <i> What is an API?</i>. [Video]. YouTube https://youtu.be/s7wmiS2mSXY <br></li>
- Simply Explained. (2019, Nov 12).<i> What Are APIs? – Simply Explained</i>. [Video]. YouTube https://youtu.be/OVvTv9Hy91Q <br></li>
- Imperva. (2019, Nov 16).<i> API Security Explained</i>. [Video]. YouTube https://youtu.be/LeVQlxLVD8A<br></li>
- Nordic APIs. (2019, May 28).<i> 5 Best Practices for Securing Your APIs</i>. [Video]. YouTube https://youtu.be/6wRuKgjbBVU<br></li>
- Udacity (2016, Jun 6).<i> Token Based Authentication</i>. [Video]. YouTube https://youtu.be/woNZJMSNbuo <br></li>
- WafaStudies. (2020, Jun 5).<i> Store Secrets in Azure Key Vault using Azure Portal</i>. [Video]. YouTube https://youtu.be/Rb7qz_emvsg<br></li>
- Paddy Maddy. (2020, Dec 24).<i> Storage Account service Encryption Azure KeyVault secret key encryption</i>. [Video]. YouTube https://youtu.be/N6nNJ_NrbS4<br>
- C. Nienaber & R. Suter. (2022, Mar). <i>ASP.NET Core web API documentation with Swagger / OpenAPI</i>. https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1
- R. Anderson & K. Larkin. (2022, Aug).<i>Tutorial: Create a web API with ASP.NET Core</i>. https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio
- R. Anderson & K. Larkin. (2022, Jul).<i> Configuration in ASP.NET Core</i>. https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0
- Sanjay. (2021, Jul).<i> Entity Framework Core in ASP.NET Core 3.1 – Getting Started</i>. https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/
- J. Muller. (2022, Jan). <i>Join two entities in.NET Core, using lambda and Entity Framerwork Core</i>. https://jd-bots.com/2022/01/24/join-two-entities-in-net-core-using-lambda-and-entity-framework-core/
- M. Soucoup. (2022, Mar). <i> Publish an ASP.NET Core web API to Azure API Management with Visual Studio </i>. https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0
- Price, M.J., 2019. <i>C# 8.0 and. NET Core 3.0–Modern Cross-Platform Development: Build applications with C#,. NET Core, Entity Framework Core, ASP. NET Core, and ML. NET using Visual Studio Code. Packt Publishing Ltd.</i>
- Chanda, S. and Foggon, D., 2013. <i>Introducing Language-Integrated Query (LINQ)</i>. In Beginning ASP. NET 4.5 Databases (pp. 79-98). Apress, Berkeley, CA.
- Azure Crash Course. <i>Azure API Management Crash Course.</i> [Video]. YouTube https://youtu.be/3z_XmIrGbsI
- DEVREAL. <i>Azure API Management in 7 (from provisioning to API deployment) - tutorial for beginners.</i> [Video]. YouTube https://youtu.be/Gu9reN09mXI
- Microsoft Azure.<i> Azure API Management.</i> [Video]. YouTube https://youtu.be/0yf_xm5cPIo
- Reval Govender. <i>Git Flow Part 1 - What is Git Flow</i>. [Video]. YouTube https://youtu.be/6LhTe8Mz6jM
