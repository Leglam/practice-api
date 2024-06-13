API-Practice Project

When you clone or pull the project for the first time there will be Migrations Folder that is the data for database but your local DB wouldn't have any of that data
because you still did not update the DB

IF YOU DON'T HAVE MIGRATIONS FOLDER USE THIS : "dotnet ef migrations add init"
USE THIS TO UPDATE YOUR DB : "dotnet ef database update"

if you can't use dotnet ef command make sure to install this tool first : "dotnet tool install --global dotnet-ef --version [Your Version]"

In this project I use this dotnet tools's version => 8.0.6

**MAKE SURE TO CHANGE THE DEFAULT CONNECTION AT appsettings.json TO BE IN THIS FORMAT**
"DefaultConnection": "Data Source=[Your Desktop's Name]\\SQLEXPRESS;Initial Catalog=[Your DB's Name];Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

and Do Not forget To cd into the api directory!
