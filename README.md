# Book Club Manager

A small ASP.NET Core MVC web app for keeping track of books and book clubs.
Built as the ASP.NET Fundamentals project.

## About

Book Club Manager lets you store a collection of books and a list of reading
clubs. The data model also includes meetings, which link a club to a book with
a date and a location. The project is the foundation for a bigger app that I
plan to extend in the ASP.NET Advanced course.

## Features

- Books: create, view, edit and delete (full CRUD)
- Clubs: list, view details and create
- Validation on the forms, on both the client and the server
  (required fields, maximum lengths)
- Shared layout with a navigation menu linking all pages
- Responsive design with Bootstrap

Not done yet: pages for creating and managing meetings (the Meeting model and
its database table exist).

## Technologies

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core (code first, migrations)
- SQL Server LocalDB
- Razor views, Bootstrap
- Dependency Injection with a service layer (`IBookMethods`, `IClubMethods`)

## Project structure

- `Data/` - database context (`BookClubDb`) and entity models
- `Services/` - interfaces and classes that handle the database work
- `Controllers/` - `BooksController`, `ClubsController`, `HomeController`
- `Views/` - Razor views for each controller, plus the shared layout
- `Migrations/` - Entity Framework migrations

## Setup

1. Install the .NET 10 SDK and Visual Studio with the SQL Server LocalDB
   component.
2. Clone the repository and open `BookClubManager.slnx`.
3. Create the database: open the Package Manager Console and run
   `Update-Database` (or run `dotnet ef database update` in the project
   folder).
4. Run the app and use the menu to open the Books and Clubs pages.

## Configuration

The connection string is in `appsettings.json` under `DefaultConnection`.
It points to SQL Server LocalDB (`(localdb)\MSSQLLocalDB`) with Windows
authentication, so no passwords or environment variables are needed.
