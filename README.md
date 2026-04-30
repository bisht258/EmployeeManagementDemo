# Employee Management Demo
Create a small Employee Management System using C# and ASP.NET Core MVC with the following features: 
 
1. Application Overview
Develop a web-based application to manage employee and department information. The application should demonstrate standard enterprise concepts such as authentication, authorization, CRUD operations, and dependency injection.
 
2. Functional Requirements
a. Login Module
Create a Login screen with the following fields:
UserId
Password
Implement user authentication to allow only valid users to access the system.
b. Employee Management
Create an Employee Details module with the following fields:
EmployeeId
FirstName
LastName
Department (e.g., HR, IT, Finance)
Implement CRUD operations (Create, Read, Update, Delete) for employees.
c. Department Management
Create a Department Details module with the following fields:
DepartmentId
DepartmentName
Implement CRUD operations for departments.
3. Security Requirements
Implement Authentication to validate users.
Implement Authorization using roles (e.g., Admin, User):
Admin: Can manage employees and departments.
User: Can view employee details only.
 
4. Technical Requirements
Use ASP.NET Core MVC architecture.
Use Dependency Injection to manage services and repositories.
Data access should be implemented using:
A Mock/In-Memory Collection for demo purposes.
Follow clean coding practices and proper separation of concerns.
 
5. Objective
The purpose of this demo project is to help trainees understand:
MVC architecture
CRUD operations
Authentication and role-based authorization
Dependency Injection
Basic data modeling and relationship
