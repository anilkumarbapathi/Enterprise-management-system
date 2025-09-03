This is a layered .NET 8 solution with API, Application, Domain, Infrastructure, and Tests.

## Projects
- **EnterpriseManagement.Api** → REST API (Controllers, Program.cs, Swagger, JWT Auth)
- **EnterpriseManagement.Application** → Services, DTOs, Interfaces, Business Logic
- **EnterpriseManagement.Domain** → Core Entities (User, Order)
- **EnterpriseManagement.Infrastructure** → EF Core DbContext, Repositories, SQL Server
- **EnterpriseManagement.Tests** → Unit tests with xUnit

## Features
- Layered architecture (Clean, maintainable)
- JWT Authentication (Login / Register)
- DTOs for request/response models
- Global error handling & Serilog logging
- EF Core SQL Server integration
- Dockerfile for containerization
- Azure Pipelines CI/CD YAML

## Setup
```bash
dotnet restore
dotnet build
dotnet ef database update --project src/EnterpriseManagement.Infrastructure --startup-project src/EnterpriseManagement.Api
dotnet run --project src/EnterpriseManagement.Api
