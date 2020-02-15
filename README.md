# signalr-web-console

@@image goes here@@

A web based output console for displaying progress messages when executing tasks using ASP.NET C# and SignalR.

## What is it?

This repository contains a simple ASP.NET web application using SignalR to send status/progress messages to the client, after they have triggered a long running process.

This feature is useful when a user triggers one or more time consuming backend processes, usually between 10-30 seconds.

In addition to just displaying messages, the project includes a console for printing the messages a.k.a web console.

Do note, the console is read-only  - for printing messages.


## How to run

Clone the repo, restore nuget packages (clean & build) and run - that's it!

(ASP.NET - 4.7.2 .Net Framework)


## How does it work?

Replicating this functionality in your own project is straight forward. 

First, Install the Microsoft ASP.NET SignalR package from nuget:
```
PM> Install-Package Microsoft.AspNet.SignalR -Version 2.1.2
```


## Hubs Folder

* Copy the **Hubs** folder into your root directory, it has the following files:
    * **Startup.cs** - This enables your web application to use SignalR
    * **ProgressHub.cs** - A derived instance of a SignalR Hub - all messaging is done here.
