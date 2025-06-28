# EmployeeManagementDBF

A layered ASP.NET MVC 4 application using Entity Framework (Database-First), following clean architecture principles and using Ninject for dependency injection.

---

## 🚀 Project Overview

This project is built to learn and demonstrate how to implement a modular and scalable ASP.NET MVC 4 application using:

- Entity Framework 6 (Database-First approach)
- Clean Architecture (separating UI, Business Logic, Domain, and Data Access)
- Ninject for Dependency Injection
- Bootstrap for responsive UI

---

## 🧱 Architecture Structure
EmployeeManagementDBF.sln
 - EmployeeManagementDBF.Web // UI Layer (ASP.NET MVC 4)
 - EmployeeManagementDBF.Application // Application Layer (business logic)
 - EmployeeManagementDBF.Domain // Domain Layer (entities, interfaces)
 - EmployeeManagementDBF.Infrastructure // Data Layer (EF, repositories)


Each layer communicates only with the next inner layer, following Clean Architecture principles.

---

## 🛠 Technologies Used

- ASP.NET MVC 4 (.NET Framework 4.5+)
- Entity Framework 6 (Database-First)
- SQL Server
- Ninject for Dependency Injection
- Bootstrap 3 (UI)
- Git & GitHub
- Visual Studio 2022

---

## 📦 Features

- Full CRUD for Employees and Departments
- Database-First EF approach with auto-generated models
- Separation of concerns across layered architecture
- Repository pattern for data access
- Ninject-based Dependency Injection
- Clean and responsive UI using Bootstrap

---

## ✅ Prerequisites

- Visual Studio 2017 or 2019
- SQL Server or SQL Server Express
- Git installed on your system
- Basic understanding of .NET MVC and EF

---

## 📥 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/imdhiren/EmployeeManagementDBF.git
