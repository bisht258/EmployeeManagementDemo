# 👨‍💼 Employee Management Demo (ASP.NET Core MVC)

This project is a **demo Employee Management System** developed using **ASP.NET Core MVC** to demonstrate core enterprise application concepts such as **authentication, authorization, CRUD operations, and dependency injection**.

---

## 📌 Application Overview

The application is a web-based system designed to manage **employees and departments**. It follows standard **MVC architecture** and demonstrates how modern enterprise applications are structured.

---

## 🚀 Features

### 🔐 1. Login Module

* User authentication using:

  * **UserId**
  * **Password**
* Only valid users can access the system
* Cookie-based authentication implemented

---

### 👨‍💼 2. Employee Management

Manage employee data with full CRUD functionality:

**Fields:**

* EmployeeId
* FirstName
* LastName
* Department (HR, IT, Finance, etc.)

**Operations:**

* ➕ Create employee
* 📄 View employee list
* ✏️ Update employee details
* ❌ Delete employee

---

### 🏢 3. Department Management

Manage departments within the organization:

**Fields:**

* DepartmentId
* DepartmentName

**Operations:**

* ➕ Create department
* 📄 View departments
* ✏️ Update department
* ❌ Delete department

---

## 🔐 Security Implementation

### ✅ Authentication

* Implemented using **ASP.NET Core Cookie Authentication**
* Ensures only logged-in users can access the system

---

### ✅ Authorization (Role-Based)

| Role  | Permissions                    |
| ----- | ------------------------------ |
| Admin | Manage employees & departments |
| User  | View employee details only     |

* Policy-based authorization implemented (`AdminOnly`)

---

## 🛠️ Technical Implementation

### 🔧 Architecture

* ASP.NET Core MVC
* Clean separation of concerns:

  * Controllers → Handle requests
  * Services → Business logic
  * Repositories → Data access

---

### 🔄 Dependency Injection

* Services and repositories are injected using built-in DI container
* Improves modularity and testability

---

### 🗄️ Data Storage

* Uses **In-Memory Collections (Mock Repositories)**
* No external database required
* Data resets when application restarts
* Designed specifically for **demo and learning purposes**

---

## 📂 Project Structure

```bash id="p8z4sh"
EmployeeMgmtDemo/
│── Controllers/        # Request handling (MVC Controllers)
│── Models/             # Data models (Employee, Department, User)
│── Services/           # Business logic layer
│── Repositories/       # In-memory data access layer
│── Views/              # Razor UI (Employees, Departments, Account)
│── wwwroot/            # Static files (CSS, JS)
│── Program.cs          # App configuration
│── appsettings.json    # Settings
```

---

## ⚙️ How to Run the Project

### 1️⃣ Clone Repository

```bash id="a3xv2j"
git clone https://github.com/bisht258/EmployeeMgmtDemo.git
cd EmployeeMgmtDemo
```

---

### 2️⃣ Open in Visual Studio

* Open `.sln` file
* Restore dependencies

---

### 3️⃣ Run Application

```bash id="9vtn7y"
dotnet run
```

---

### 🌐 Access Application

```id="fqlqxy"
https://localhost:xxxx
```

---

## 🎯 Objective of the Project

This project was developed to demonstrate understanding of:

* MVC architecture
* CRUD operations
* Authentication & role-based authorization
* Dependency Injection
* Repository & Service design patterns
* Basic data modeling

---

## 📌 Key Highlights

* Clean and modular architecture
* Demonstrates enterprise-level concepts in a simplified way
* Easily extendable to:

  * SQL Server (Entity Framework Core)
  * REST APIs
  * Frontend frameworks (React/Angular)

---

## 🔮 Future Enhancements

* Integrate **SQL Server + Entity Framework Core**
* Add **role management UI**
* Implement **pagination & search**
* Add **form validations**
* Deploy to **Azure / AWS**

---

## 👨‍💻 Author

**Kl Bisht**

* GitHub: https://github.com/bisht258

---

## ⭐ Support

If you found this project useful, consider giving it a ⭐ on GitHub!
