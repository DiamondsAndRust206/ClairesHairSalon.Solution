# Claire's Hair Salon

#### By Ryan Gibson

#### This is a hair salon webpage that keeps track of hair stylist and their customers.

## Technologies Used

* C#
* HTML
* CSS
* MySQL Workbench
* ASP.NET
* Entity Framework
* REPL
* Razor

## Description

This webpage was programmed using C#, ASP.NET & Entity. It is a hair salon that allows the user to add stylists with a specialty. The user can then add a customer to that stylist. This is done using the SQL Workbench for the database with two tables, one for stylists and the other for customers.

## Setup/Installation

* At https://github.com/DiamondsAndRust206/ClairesHairSalon.git copy the git repository URL from the green "code" button.
* Open a shell program & navigate to your desktop
* Clone the repository using the copied URL and the "git clone" command
* In the shell program, navigate to the root directory of the newly created file called "HairSalon.Solution"
* From the root directory, navigate to the directory named "HairSalon"
*  Open Terminal and navigate to the type HairSalon and type "dotnet restore".
* Type "dotnet build" : this will help you to have all the technologies you need to run you test.
* In the HairSalon directory create a file named "appsettings.json"
* Add the following code to the newly created .json file
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
* Before commit and pushing to your remote repo make sure to add the "appsettings.json" file to your .gitignore file because it contains sensitive information.
* Open Your MySql workbench and navigate to Administrator
* Select DataImport /Restore
* Navigate to the Project Directory
* Imoprt the file name ryan_gibson.sql
* In the HairSalon directory type "dotnet run" to start the program
* Open a web browser and plug "http://localhost:5000/" into the URL bar

## Known Bugs

* No known issues

## License

[MIT](LICENSE)

Copyright (c) 2022 Timothy R Gibson