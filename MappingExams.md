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

[Entity Framework Development workflows](http://msdn.microsoft.com/en-US/data/jj590134)

[DataAdapters and DataReaders](http://msdn.microsoft.com/en-us/library/ms254931(v=vs.110).aspx)

[ASP.NET State Management overview](http://msdn.microsoft.com/en-us/library/75x4ha6s(v=vs.100).aspx)

## Deployment Architecture

* Gulp, grunt, npm, Bower, Less, Sass, Font awesome, JavaScript, CSS
* Server Build strategy - NuGet - .NET Core, .NET Framework, debug, release, compile, optimization, include files for build, XML Doc
* Publishing strategy - dotnet, publish options csproj, pre-publish, post-publish, publish to docker
* Azure deployment - FTP, Kudu, Web Deploy, Visual Studio Publish, dev, test in Azure, deployment slots, Azure Stack
* On-premise deployment - Web deploy, xcopy, VS publish, http.sys, Kestrel, reverse proxy to Kestrel with IIS and Nginx

[Developing with .NET on Microsoft Azure](https://www.pluralsight.com/courses/developing-dotnet-microsoft-azure-getting-started?aid=7010a000001xH0EAAU&promo=&oid=&utm_source=&utm_medium=partner_partner_web_referral&utm_campaign=&utm_content=&utm_term=)

[Building your CI/CD pipeline](https://channel9.msdn.com/Events/dotnetConf/2017/T323/)

[Developing ASP.NET MVC 5 Web Applications](https://www.microsoft.com/en-us/learning/course.aspx?cid=20486)

## Design User Experience

* CSS, dynamic pages
* JavaScript invoke DOM, AJAX partial updates
* UI layout - view components, Razor Pages, page sections, HTML helpers
* Responsive UI - media queries, Bootstrap, detect browser features, polyfills
* Mobile UI - touch, low bandwidth, device orientation

[Build a better mobile browsing experience](http://msdn.microsoft.com/en-us/magazine/hh288079.aspx)

[Display modes](http://www.asp.net/whitepapers/mvc4-release-notes#_Toc303253810)

[Building Modern Web Apps Jump Start](https://mva.microsoft.com/training-courses/building-modern-web-apps-jump-start)


## Develop User Experience

* Search optimization, xml sitemap, robots.txt
* Globalization, localization
* MVC controllers, actions, HTTP status codes, action results, DI
* Routes - custom route parameters, SPA with Angular
* Behavior and MVC extension points - middleware, MVC filters, controller factories, action results, model binders, route handlers, inject services in views
* JSON, XML, SOAP, WCF, web sockets

[Search Engine Optimization Toolkit](http://www.iis.net/downloads/microsoft/search-engine-optimization-toolkit)

[GlobalizationSection Class](http://msdn.microsoft.com/en-us/library/system.web.configuration.globalizationsection.aspx)

[FormCollection Class](http://msdn.microsoft.com/en-us/library/system.web.mvc.formcollection(v=vs.118).aspx)

## Troubleshooting and Debug

* troubleshoot performance, security, tracing, logging, debugging, IntelliTrace, health monitoring, App Insights
* exception handling - debug/production, app insights
* Mocks and stubs, web tests, browser links, Azure DevOps
* Debug Azure - remote debugging, crash dumps, stream logs

[Using shims to isolate your application from other assemblies for unit testing](http://msdn.microsoft.com/en-us/library/hh549176(v=vs.120).aspx)

## Design and Implement Security

* Authentication - ASP.NET Core identity, Facebook, Google, MFA, Azure AD, B2C AD, cookies
* Roles - role programmatically, UserStores, middleware, controllers with authorization
* Claims-based authentication OpenID, OAuth, bearer tokens
* Secure sites - SSL, Anti-XSS, SQL injection, XSRF, CORS

[Introduction to ASP.NET Identity](http://www.asp.net/identity/overview/getting-started/introduction-to-aspnet-identity)

[Chapter 5: Authentication, authorization, and identities in WCF](http://msdn.microsoft.com/en-us/library/ff647503.aspx)

[Easy Web App Integration with Windows Azure Active Directory, ASP.NET & Visual Studio](http://blogs.technet.com/b/ad/archive/2013/06/26/improved-windows-azure-active-directory-integration-with-asp-net-amp-visual-studio.aspx)

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
* MySQL, SQLite

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

# Plans

## Tuesday / Wednesday

* Authentication 20486, Chapter 11; 20487, Chapter 9
* Hosting (Linux, Windows, OWin) 20487, Chapter 5
* SOAP, WCF!!!
* EF Core, 20487, Chapter 2
* Logging, 20487, Chapter 8
* Docker

## Thursday

* WCF Data Services
* Azure Cosmos DB, 20487, 7
* HttpClient, factory 20487, 3
* Logic Apps
* Traffic Management
* API Management
* Azure DevOps