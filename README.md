# Employee CRUD Application

This is a simple full-stack web application built with ASP.NET Core Razor Pages to demonstrate basic CRUD (Create, Read, Update, Delete) operations.

## Technologies Used

* **Backend:** ASP.NET Core 8.0 (C#)
* **Database:** SQL Server (using Entity Framework Core)
* **Frontend:** Razor Pages (HTML, CSS, C#)

## Features

* **Create:** Add a new employee to the database.
* **Read:** View a list of all employees and their details.
* **Update:** Edit the details of an existing employee.
* **Delete:** Remove an employee from the database.

## How to Run the Project

Follow these steps to set up and run the application locally on your machine.

### Prerequisites

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (with ASP.NET and web development workload)

### Steps

1.  **Clone or Download the Repository:**
    ```bash
    git clone [repo-link]
    cd EmployeeCrudApp
    ```

2.  **Restore NuGet Packages:**
    Open the project in Visual Studio. The packages should restore automatically. If not, run the following command in the terminal:
    ```bash
    dotnet restore
    ```

3.  **Run Database Migrations:**
    Open the `Package Manager Console` in Visual Studio (**Tools > NuGet Package Manager > Package Manager Console**) and run these commands to create the database tables:
    ```bash
    Add-Migration InitialCreate
    Update-Database
    ```

4.  **Run the Application:**
    Press `F5` in Visual Studio or use the following command in the terminal:
    ```bash
    dotnet run
    ```

5.  **Access the Application:**
    Once the application is running, open your web browser and navigate to the `/Employees` endpoint.
    ```
    https://localhost:7284/Employees
    ```

---
