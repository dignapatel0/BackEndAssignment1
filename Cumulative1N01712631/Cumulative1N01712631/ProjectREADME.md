# School Database Web Application

This project retrieves data from a **School** database and displays information about **Teachers**, **Students**, and **Courses**.

## Database Configuration

This project uses **XAMPP** with the default settings:

- **User**: `root`
- **Password**: (empty, default no password)
- **Port**: `3306`

It connects to a MySQL database named **schooldb**, which contains the following tables:

- `courses`: Stores information about courses offered by the school.
- `students`: Contains student data such as names and enrollment details.
- `studentsxcourses`: A relationship table linking students to courses they are enrolled in.
- `teachers`: Holds teacher information such as name, employee number, hire date, and salary.

## Technologies Used

The project is developed in **Visual Studio** using the **ASP.NET Core Web Application (MVC)** framework, which follows the **Model-View-Controller (MVC)** design pattern.

### NuGet Packages

The following **NuGet packages** are used in this project:

- **MySql.Data**: MySQL data provider for .NET to allow database interaction.
- **Swashbuckle.AspNetCore.SwaggerGen**: Generates Swagger API documentation.
- **Swashbuckle.AspNetCore.SwaggerUI**: Provides an interactive Swagger UI to test the API endpoints.
