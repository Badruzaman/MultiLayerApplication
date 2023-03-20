# Multi-Layered architecture application in .net core web api
This is a sample application with a multi-layered architecture built using .NET Core Web API. The application consists of four projects, three of which are class libraries, and the fourth is a web API.
The domain project contains all the models and interfaces implemented in the DAL project and the service project. The code follows a code-first approach where database migration is performed in a separate class library, rather than in the web API project.

## Tools and Technology 
+ Microsoft SQL Server 2022 (RTM) - 16.0.1000.6 (X64) Developer Edition (64-bit)
+ Microsoft Visual Studio Enterprise 2022 (64-bit) - Current Version 17.5.1
+ MS .Net Core Web Api (.NET 7.0)
+ Core First Approach
+ Entity Framework Core

## Project Architecture 
![Architecture](/MultiLayerApplication.Api/images/Structure.PNG)

## Project Run Issue
If the application shows this error while running, please visit the URL and follow the instructions. 
https://stackoverflow.com/questions/26424902/process-with-an-id-of-is-not-running-in-visual-studio

![Issue](/MultiLayerApplication.Api/images/RunningIssue.png)

