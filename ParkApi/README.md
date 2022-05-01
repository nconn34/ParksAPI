**State and National Park API**

#### By **Nathan Conn**

#### This program was designed to track and store data about State and National Parks, including name, location, and preferred activities.


## Technologies Used

* C#
* NET 5.0
* MVC
* Swashbuckle



## Description

Use the CRUD methods to add new parks to the database by opening up Postman, launching the browser, using the main page url, and utilizing Post or Put through Postman. You will want to make sure that you are under the raw data section and that JSON is selected for data type.

## Endpoints

Base URL: https://localhost:5001

GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}

https://localhost:5001/api/park/5

{
    "Id": 5,
    "Name": "Wyalusing",
    "Type": "SP",
    "Location": "Wisconsin",
    "YearFounded": 1926,
    "Activities" = "Kayaking"
}

## Setup/Installation Requirements

* Clone repository.
* In the main file, add an appsettings.json file and include the following code:

{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:61475",
      "sslPort": 44376
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "ParkApi": {
      "commandName": "Project",
      "dotnetRunMessages": "true",
      "launchBrowser": true,
      "launchUrl": "",
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
* 

* In the command line, run "dotnet ef migrations add Initial" (and label each one different with any update you make)
* In the command line, run "dotnet ef migrations add SeedData"
* In the command line, run "dotnet ef database update"

* 
* In the command line, run "dotnet restore" in the ParkApi directory.
* In the command line, run "dotnet build" in  the ParkApi and directory.
* In the command line, run "dotnet run" while in the ParkApi directory to run the program.
* You will need to create an appsettings.json file in order to use and store information into the database that is attached. Use the code below and replace the necessary fields with your information:

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=DBNAMEHERE;uid=root;pwd=PASSWORDHERE;"
    }
}


## Known Bugs

* Currently, the string values will not accept entries that include multiple words, and even multiple words with no spaces (example: "RockyMountainNationalPark" and "Rocky Mountain National Park" return the same error, but "Rockymountainnationalpark" works). 
* Currently, Swagger is functional but is unable to fetch data, and I am unsure what the fix is after trying several options I looked up. 

## Contact Me

Let me know if you run into any issues or have questions, ideas, or concerns:
nconn34@gmail.com

## License

Copyright (c) 4/23/2022 Nathan Conn