

\# Student Management System API



A RESTful Web API developed using \*\*ASP.NET Core 10, C#, Entity Framework Core, and Microsoft SQL Server\*\* to manage student records.



This project demonstrates backend development, database integration, CRUD operations, asynchronous programming, and REST API design.



\## Technologies Used



\- C#

\- ASP.NET Core Web API (.NET 10)

\- Entity Framework Core

\- Microsoft SQL Server

\- SQL Server Management Studio (SSMS)

\- Visual Studio

\- Git and GitHub



\## Features



\- Retrieve all students

\- Retrieve a student by ID

\- Add a new student

\- Update existing student details

\- Delete a student

\- Validate student information

\- Store student records in SQL Server

\- Asynchronous database operations

\- Centralized exception handling



\## API Endpoints



| Method | Endpoint | Description |

|--------|----------|-------------|

| GET | `/api/Students` | Retrieve all students |

| GET | `/api/Students/{id}` | Retrieve student by ID |

| POST | `/api/Students` | Add a new student |

| PUT | `/api/Students/{id}` | Update student details |

| DELETE | `/api/Students/{id}` | Delete a student |



\## Student Model



| Property | Type | Description |

|----------|------|-------------|

| Id | int | Unique student identifier |

| Name | string | Student name |

| Email | string | Student email |

| Age | int | Student age |

| Course | string | Enrolled course |



\## Example Request



POST `/api/Students`



```json

{

&#x20; "name": "Rahul Sharma",

&#x20; "email": "rahul@example.com",

&#x20; "age": 21,

&#x20; "course": "MCA"

}

```



\## Database Configuration



The application uses Entity Framework Core with SQL Server.



Configure your SQL Server connection in `appsettings.json` or through local configuration.



Example for a local SQL Server instance using Windows Authentication:



```json

{

&#x20; "ConnectionStrings": {

&#x20;   "DefaultConnection": "Server=localhost;Database=StudentManagementDB;Trusted\_Connection=True;TrustServerCertificate=True;"

&#x20; }

}

```



Do not commit production credentials or secrets to GitHub.



\## How to Run



1\. Clone the repository:



&#x20;  ```bash

&#x20;  git clone https://github.com/kamalxnarayan/StudentManagementSystem.API.git

&#x20;  ```



2\. Open `StudentManagementSystem.slnx` in Visual Studio.



3\. Install the .NET 10 SDK and ensure SQL Server is running.



4\. Configure the SQL Server connection string.



5\. Open the Package Manager Console and run:



&#x20;  ```powershell

&#x20;  Update-Database

&#x20;  ```



6\. Build and run the application.



7\. Test the API endpoints using an HTTP client.



\## Project Structure



```text

StudentManagementSystem.API/

├── Controllers/

│   └── StudentsController.cs

├── Data/

│   └── ApplicationDbContext.cs

├── Middleware/

│   └── ExceptionHandlingMiddleware.cs

├── Migrations/

├── Models/

│   └── Student.cs

├── Program.cs

└── appsettings.json

```



\## Future Improvements



\- JWT authentication and authorization

\- Pagination and search functionality

\- DTOs and AutoMapper

\- FluentValidation

\- Unit testing

\- API documentation

\- Cloud deployment



\## Author



\*\*Kamal Narayan\*\*



GitHub: https://github.com/kamalxnarayan



\## License



No license has been specified for this repository.



