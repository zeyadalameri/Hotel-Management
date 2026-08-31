# Hotel Management System

A Windows desktop application for learning and demonstrating common hotel-administration workflows with a SQL Server database.

## Key Features

- Employee sign-in and role-aware dashboard access
- Room creation, pricing, availability, and occupancy status
- Guest registration and room assignment
- Customer record search and review
- Check-out workflow
- Employee record management

## Tech Stack

- C#
- Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server
- ADO.NET
- Guna.UI2.WinForms

## Architecture

The solution uses Windows Forms for the desktop interface and ADO.NET for direct SQL Server access. Forms are separated by workflow, while `SQLQuery1.sql` creates the local database schema and sample room records.

## Getting Started

1. Install Visual Studio with .NET desktop development and SQL Server.
2. Run `SQLQuery1.sql` in SQL Server Management Studio. **Warning:** the script recreates the application tables and is intended only for a disposable local database.
3. The schema script inserts a clearly synthetic demo administrator for local evaluation. Review `SQLQuery1.sql` and replace or remove that record before using any shared database.
4. Update the local SQL Server connection string in the application for your environment.
5. Restore NuGet packages and open `Hotel Management.sln` in Visual Studio.

## My Role

I developed the database schema, WinForms screens, navigation, room and guest workflows, employee management, and SQL Server integration as a desktop application project.

## Skills Demonstrated

C# desktop development, Windows Forms, ADO.NET, SQL Server schema design, CRUD workflows, and event-driven user interfaces.

## Project Status and Limitations

This is an academic/portfolio desktop application and is not production-ready. Passwords are currently stored as plain text, several database operations build SQL dynamically, and the connection string is configured in source. Before real use, it would require password hashing, fully parameterized queries, secret configuration, authorization review, tests, audit logging, and deployment packaging.

## License

No open-source license has been declared.
