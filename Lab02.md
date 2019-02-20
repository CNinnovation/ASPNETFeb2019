# Lab 02 - Using .NET Core Libraries

## Dependency Injection

1. Create a console application
2. Create a service contract *IHelloService* with a *Hello* method
3. Create *HelloController* with constructor injection using the IHelloService, and a *Greeting* method using the *IHelloService*
4. Create a concrete imlpementation for the IHelloService
5. Use the *HelloController* from the *Program* class
6. Add the NuGet package *Microsoft.Extensions.DependendyInjection*
7. Register services *IHelloService* and *HelloController* with the container
8. Use the *HelloController* by getting a reference from the container

Questions:

1. How is the *HelloController* instantiated?
2. What happens if the IHelloService implementation cannot be found?

## Configuration

1. Create a console application
2. Add NuGet packages for *Microsoft.Extensions.Configuration.*
3. Create a configuration builder
4. Create a JSON configuration file to store a connection string
5. Configure the application to invoke it using paramters, e.g. a=42
6. Read the configuration values from the application
7. Add User Secrets to the program, to read user secrets

Questions:

1. How can inner sections be retrieved?
2. Is it possible to get all configured values?
3. What happens if the same value is configured multiple times?
4. What are user secrets good for?

## Logging

1. Create a console application
2. Add NuGet packages for "Microsoft.Extensions.Logging.*"
3. Create a logging factory to set up logging, write logs to the console
4. Write log messages from your *Main* program

Questions:

1. What logging framework did you use?
2. Why another logging framework?
3. Does the logging framework support severity levels?
4. Does the logging framework support scopes?
5. Can logging be configured to use NLog?

