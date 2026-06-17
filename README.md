# CRN Product Management REST API

This is a simple Product Management REST API built using ASP.NET Core 8.  
I developed this project as part of a technical assessment to demonstrate my backend development skills using clean architecture principles.

---

## Project Overview

This project provides basic product management features like:

- Create Product
- Get All Products
- Get Product by Id
- Update Product
- Delete Product

It also includes authentication, validation, logging, and unit testing to make it more production-ready.

---

## Architecture

I followed Clean Architecture approach to structure this project properly and keep it maintainable.

Project is divided into:

- API (Controllers, Middleware, Configuration)
- Application (DTOs, Interfaces, Services, Validation, Mapping)
- Domain (Entities, Core Models)
- Infrastructure (Database, Repositories, EF Core Implementation)

---

## Tech Stack

- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server (LocalDB)
- JWT Authentication
- AutoMapper
- FluentValidation
- Serilog Logging
- xUnit + Moq (Unit Testing)

---

## Authentication

JWT authentication is implemented in this project.

Steps to use:
1. Call `/api/Auth/login`
2. Copy the token from response
3. Go to Swagger UI
4. Click Authorize button
5. Paste token like:

   Bearer your_token

After this, all secured APIs can be accessed.

---

## Database

I used SQL Server LocalDB for development.

Connection String:
Server=(localdb)\MSSQLLocalDB;
Database=CRNProductManagementDb;
Trusted_Connection=True;

Tables used:
- Product
- Item

---

## How to Run Project

- Clone the repository
- Open solution in Visual Studio
- Restore NuGet packages
- Check connection string in appsettings.json
- Run migration using:
  Update-Database
- Run project using IIS Express / Kestrel

---

## Testing

Unit tests are written using:

- xUnit
- Moq

To run tests:

dotnet test

---

## Logging

Serilog is used for logging in this project.

Logs are stored in:
- Console output
- Logs folder (file logging enabled)

---

## API Endpoints

Product APIs:

- GET /api/Product
- GET /api/Product/{id}
- POST /api/Product
- PUT /api/Product/{id}
- DELETE /api/Product/{id}

Auth API:

- POST /api/Auth/login

---

## What I Learned

While building this project, I learned:

- How to structure a real-world backend application
- Clean architecture implementation
- JWT authentication flow
- Dependency injection best practices
- Writing unit tests using mocking
- Logging and validation techniques

---

## Screenshot

(Add Swagger UI running screenshot here before submission)

---

## Author

Nitesh Patil
