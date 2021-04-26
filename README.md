# CustomerCadaster

This is a desktop application developed with C# using Windows Forms, Entity Framework, .Net Core 3.1 and SQL Server 18.8.

# Overview

This application is a CRUD to manage customers data.

# How to start

* Clone

    Clone this repository.

* Connection string

    Create a appSettings.json file within the Cadaster.UI project and paste the code below replacingo with your data.    
   
   > {        
   >   "ConnectionStrings": { "DbConn": "Server=\<SERVER\>;Database=CustomerCadaster;User=\<USER\>;Password=\<Password\>;" }    
   > }    
	    
* Database
    
    Now that the connection string is properly defined, open the command line tool, access the solution folder and run the database update
    > dotnet ef database update -p Cadaster.UI/Cadaster.UI.csproj    
