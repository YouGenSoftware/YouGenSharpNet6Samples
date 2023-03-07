# Northwind_BackEndDatabaseClientTests
This contains scoped integration tests corresponding to the CRUD repositories in the Northwind_BackEndDatabaseClient project.
# Concepts Employed
* Scoped Integration Tests are classes implementing MS Test Framework to test pieces of logic in the Repositories, effecting actualized changes in the underlying database target.
# 3rd Party Functionalities/Technologies/Libraries Employed
* [Microsoft DotNet 6.0 Software Development Kit](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [Coverlet.Collector](https://github.com/coverlet-coverage/coverlet)
* [Moq](https://github.com/Moq)
* [Tynamix ObjectFiller](https://objectfiller.net/)
# Additional Notes
* Depending on the configuration set for the dependency registration of the Entity Framework Core context, tests against tables and views may be completed against an In-Memory test database provider instead of a live database. Stored Procedures are not supported by the In-Memory provider.
