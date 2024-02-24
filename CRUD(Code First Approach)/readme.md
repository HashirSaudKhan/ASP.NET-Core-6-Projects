Introduction
This project is a .NET Core 6 application that utilizes Microsoft SQL Server and Entity Framework Core with a Code First approach. It focuses on performing CRUD (Create, Read, Update, Delete) operations on a database. The application is designed to showcase the capabilities of .NET Core 6 and Entity Framework Core in building a robust and efficient data management system.

Features
Create Operation: Allows users to add new records to the database.
Read Operation: Provides functionality to retrieve and display existing records from the database.
Update Operation: Enables users to modify existing records in the database.
Delete Operation: Allows users to remove records from the database.
Technologies Used
.NET Core 6: The framework used to build the application.
Entity Framework Core: Employed with a Code First approach for database modeling and interaction.
Microsoft SQL Server: The relational database management system used for data storage.
Getting Started
Prerequisites
.NET Core 6 SDK
Microsoft SQL Server
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/your-username/your-repo.git
Navigate to the project directory:

bash
Copy code
cd your-repo
Build and run the application:

bash
Copy code
dotnet build
dotnet run
Access the application in your browser at http://localhost:5000.

Configuration
Database Connection
In the appsettings.json file, update the connection string under the ConnectionStrings section to match your SQL Server configuration.

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YourDatabase;User Id=YourUsername;Password=YourPassword;"
}
Usage
Create Operation: Visit the create page, fill in the required information, and submit the form to add a new record.

Read Operation: Navigate to the read page to view existing records in the database.

Update Operation: Go to the update page, select the record you want to modify, make the necessary changes, and save.

Delete Operation: Access the delete page, choose the record you wish to delete, and confirm the deletion.

Contributions
Feel free to contribute to this project by opening issues or submitting pull requests. Contributions are highly welcomed!

License
This project is licensed under the MIT License.

Acknowledgments
Special thanks to the .NET Core and Entity Framework Core communities for their continuous support and contributions.
