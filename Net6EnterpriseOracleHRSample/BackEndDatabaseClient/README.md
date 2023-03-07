# XE_HR_BackEndDatabaseClient
This contains CRUD repositories which encompass the indexed query patterns for the target database.
# Concepts Employed
* Repositories are classes implement Entity Framework Core, Entity Framework Plus, Dapper, and ADO.NET functionality to interact with database objects.
# 3rd Party Functionalities/Technologies/Libraries Employed
* [Microsoft DotNet 6.0 Software Development Kit](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [Entity Framework Plus](https://entityframework-plus.net/)
* [ADO.NET](https://learn.microsoft.com/en-us/sql/connect/ado-net/overview-sqlclient-driver)
* [Dapper](https://github.com/DapperLib/Dapper)
# Additional Notes
* Entity Framework Core is used for direct table and view access.
* Entity Framework Plus is used for bulk update and deletes through Entity Framework Core.
* ADO.NET is used for Oracle Package and SQL Server stored procedure support
* Dapper is used to simplify ADO.NET usage
