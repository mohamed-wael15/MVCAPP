▶ Company Management System
------------------------------------------------------
▶ Project Description

 A company management system that contains three main modules:
  1. Employees: Employees can be added, updated or deleted.
  2. Departments: New departments can be added, data updated or departments deleted.
  3. Users: User data can be controlled and roles assigned to them, such as setting them as supervisors or regular users.
-------------------------------------------------------
▶ Features

The Company Management System offers the following key features:

1-Employee Management

 - Add new employees.
 - Edit employee details.
 - Delete employees.
   
2-Department Management

 - Add new departments.
 - Update department details.
 - Remove departments.
   
3-User Management

 - Add new users with specific roles.
 - Update user details and assign roles.
 - Delete users from the system.
  
4-Role-Based Access Control (RBAC)

 - Admin users can manage all system data.
 - Restrict or allow features based on user roles.
  
5-Data Management

 - Complete CRUD (Create, Read, Update, Delete) operations for all entities.
   
6-Authentication and Authorization

 - User login/logout with secure identity management.
 - Role-based authorization using ASP.NET Identity.
  
7-Separation of Concerns

 - Utilizes the Unit of Work pattern to organize database operations.

8-Efficiency with Modern Tools

 - AutoMapper for seamless data mapping between entities and DTOs.
 - LINQ for efficient database querying.
   
9-Database Management

 - Database design supports scalability and integrity.
 - Built using SQL Server and managed with Entity Framework.
----------------------------------------------------------------
▶ Technologies used
- ASP.NET MVC: To build the backend.
- C#: The basic programming language.
- SQL Server: The database used to store data.
- Entity Framework (EF) to manage the database.
- LINQ: To query data efficiently.

● Other Technologies used
- Unit of Work: To manage processes in an organized manner.
- DTO (Data Transfer Objects): To transfer data between project layers.
- AutoMapper: To facilitate data transformation between entities and DTO.
- Identity: To manage users and permissions.
-------------------------------------------------
▶ Setup Instructions

1-Clone the Repository

 Clone the project to your local machine:
 
    git clone https://github.com/mohamed-wael15/MVC-CompanyAPP.git

 2-Database Setup:
 
   - Make sure you have SQL Server installed.
     
   - Update the database connection settings in the appsettings.json file.   

 3-Migrations application
 
   - Use the following command to create the database:
     
         Update-Database

 4-Project operation:
 
   - Run the project through Visual Studio.


  
