# 70-486

## Design Application Architecture

* ASP.NET Core, ASP.NET, .NET Standard
* Azure Functions, Web Jobs, Queues, Azure Pack
* Life cycle - start, run, stop events, startup tasks, IIS, app pool configuration
* State management - in-process, out-of-process, Redis, scalability plans, cookies, local storage, web.config configuration, sessionless state, middleware, application state
* Caching - HTTP caching, Azure Redis caching, CDN
* Web Sockets, SignalR, enable in App Services
* Configuration - XML, INI, JSON, environmental variables, Option objects, user secrets, Azure Key vault
* Hosting - Linux, Windows, OWIN
* Framework pipeline - Http.sys, Kestrel, startup filters

## Deployment Architecture

* Gulp, grunt, npm, Bower, Less, Sass, Font awesome, JavaScript, CSS
* Server Build strategy - NuGet - .NET Core, .NET Framework, debug, release, compile, optimization, include files for build, XML Doc
* Publishing strategy - dotnet, publish options csproj, pre-publish, post-publish, publish to docker
* Azure deployment - FTP, Kudu, Web Deploy, Visual Studio Publish, dev, test in Azure, deployment slots, Azure Stack
* On-premise deployment - Web deploy, xcopy, VS publish, http.sys, Kestrel, reverse proxy to Kestrel with IIS and Nginx

## Design User Experience

* CSS, dynamic pages
* JavaScript invoke DOM, AJAX partial updates
* UI layout - view components, Razor Pages, page sections, HTML helpers
* Responsive UI - media queries, Bootstrap, detect browser features, polyfills
* Mobile UI - touch, low bandwidth, device orientation

## Develop User Experience

* Search optimization, xml sitemap, robots.txt
* Globalization, localization
* MVC controllers, actions, HTTP status codes, action results, DI
* Routes - custom route parameters, SPA with Angular
* Behavior and MVC extension points - middleware, MVC filters, controller factories, action results, model binders, route handlers, inject services in views
* JSON, XML, SOAP, WCF, web sockets

## Troubleshooting and Debug

* troubleshoot performance, security, tracing, logging, debugging, IntelliTrace, health monitoring, App Insights
* exception handling - debug/production, app insights
* Mocks and stubs, web tests, browser links, Azure DevOps
* Debug Azure - remote debugging, crash dumps, stream logs

## Design and Implement Security

* Authentication - ASP.NET Core identity, Facebook, Google, MFA, Azure AD, B2C AD, cookies
* Roles - role programmatically, UserStores, middleware, controllers with authorization
* Claims-based authentication OpenID, OAuth, bearer tokens
* Secure sites - SSL, Anti-XSS, SQL injection, XSRF, CORS

# 70-487

## Accessing Data

* ADO.NET, EF, EF Core, WCF Data Services, Cosmos DB
* Caching, CacheDependency, Redis
* Transactions - System.Transactions, isolation levels
* Azure Storage, Cosmos, Tables, Queues, Azure SQL, CDN
* WCF Data Services

## EF and EF Core

* query, manipulate data
* LINQ to entities
* ADO.NET
* EF data models - TPH, TPT, POCO, SSDL, MSL, CSDL..
* MySQL, SQLLite

## Web APIs

* design Web API
* implement Web API
* secure Web API
* Host, manage Web API
* Consume Web APIs (Swagger, HttpClient, retry requests)

## Implement Web Services

* Consume WCF
* Logic Apps, API Apps, Azure Functions, Web Jobs
* Traffic management - load balancing, scaling, application gateways
* API management
* Monitor web services

## Deploying Web applications and services

* Web deploy, web publish, docker, CI & CD, TFS build server
* Deployment to Azure - slots, ARM templates
* Configure web applications for deployment - transform configuration, config settings, Azure Key vaults
* NuGet - local repository, resolve version conflicts
* Share assemblies - multiple servers, sign assemblies, GAC, versioning, .NET Standard