# E-shop API
Small REST API using .NET 6/C# 10, Entity Framework and MSSQL.

## How To run:
### Required software installed: 
- MSSQL server: https://www.microsoft.com/cs-cz/sql-server/sql-server-downloads
- .NET 6 SDK: https://dotnet.microsoft.com/en-us/download
- IDE (tested on VS 2022 and Rider): https://visualstudio.microsoft.com/cs/vs/ / https://www.jetbrains.com/rider/download/

### Steps:
1) Clone the repository with Git or Download it. 
2) Prepare Database:
- Run Migrations in Infrastructure/Migrations/ and then run SQL script in Data/onlyData/
- OR
- Run SQL scripts in DATA/WithDDL (Be Aware that this is easier and faster, but your Migrations will be inconsistent, and there can be problems with future migrations).
3) Run E-shopAPI Project in your IDE.
4) Swagger will be available on https://localhost:7287/swagger/

### Future Commits and plans
- add Automapper
- add Fluent Validation
- add more Unit tests 
- add Integration tests