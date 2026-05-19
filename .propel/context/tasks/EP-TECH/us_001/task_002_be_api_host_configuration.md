# Task - task_002_be_api_host_configuration

## Requirement Reference

- User Story: US_001
- Story Location: .propel/context/tasks/EP-TECH/us_001/us_001.md
- Acceptance Criteria:
  - AC-3: Given the API project is started, When a health check endpoint is called, Then the API MUST return a 200 OK response confirming the application is running.
  - AC-4: Given the solution structure is created, When inspecting the Presentation layer, Then it MUST contain a Program.cs with ASP.NET Core Web API configuration, dependency injection registration, and middleware pipeline setup.
- Edge Case:
  - EC-2: How does the system handle missing configuration values at startup? Application MUST throw a descriptive startup exception listing missing required configuration keys.

## Design References (Frontend Tasks Only)

| Reference Type | Value |
|----------------|-------|
| **UI Impact** | No |
| **Figma URL** | N/A |
| **Wireframe Status** | N/A |
| **Wireframe Type** | N/A |
| **Wireframe Path/URL** | N/A |
| **Screen Spec** | N/A |
| **UXR Requirements** | N/A |
| **Design Tokens** | N/A |

## Applicable Technology Stack

| Layer | Technology | Version |
|-------|------------|---------|
| Backend | .NET (ASP.NET Core Web API) | 8.0 |
| Database | PostgreSQL | 16+ |
| ORM | Entity Framework Core | 8.0 |

## AI References (AI Tasks Only)

| Reference Type | Value |
|----------------|-------|
| **AI Impact** | No |
| **AIR Requirements** | N/A |
| **AI Pattern** | N/A |
| **Prompt Template Path** | N/A |
| **Guardrails Config** | N/A |
| **Model Provider** | N/A |

## Mobile References (Mobile Tasks Only)

| Reference Type | Value |
|----------------|-------|
| **Mobile Impact** | No |
| **Platform Target** | N/A |
| **Min OS Version** | N/A |
| **Mobile Framework** | N/A |

## Task Overview

Configure the ASP.NET Core Web API host in `Program.cs` with the full middleware pipeline, dependency injection registrations for all layers, health check endpoints, and startup configuration validation. This establishes the API entry point that wires together all Clean Architecture layers.

## Dependent Tasks

- task_001_be_solution_structure — Requires the solution and all four projects to exist

## Impacted Components

- MODIFY: `src/AiSmartReminder.Api/Program.cs` — Replace template-generated Program.cs with production configuration
- NEW: `src/AiSmartReminder.Application/DependencyInjection.cs` — Application layer DI registration extension method
- NEW: `src/AiSmartReminder.Infrastructure/DependencyInjection.cs` — Infrastructure layer DI registration extension method
- NEW: `src/AiSmartReminder.Api/appsettings.json` — Application configuration with required keys
- NEW: `src/AiSmartReminder.Api/appsettings.Development.json` — Development-specific overrides

## Implementation Plan

1. Create `DependencyInjection.cs` in Application project with `AddApplicationServices()` extension method on `IServiceCollection`
2. Create `DependencyInjection.cs` in Infrastructure project with `AddInfrastructureServices(IConfiguration)` extension method on `IServiceCollection`
3. Replace template `Program.cs` with production configuration:
   - Register services: `builder.Services.AddApplicationServices()` and `builder.Services.AddInfrastructureServices(builder.Configuration)`
   - Add health checks: `builder.Services.AddHealthChecks()`
   - Add controllers: `builder.Services.AddControllers()`
   - Configure CORS policy
   - Build middleware pipeline: exception handler → HTTPS redirection → CORS → routing → authorization → health check endpoint → controllers
4. Map health check endpoint at `/health` returning 200 OK with JSON response body
5. Configure `appsettings.json` with required configuration sections (ConnectionStrings, JwtSettings, etc.) using placeholder values
6. Implement startup configuration validation that throws a descriptive exception listing all missing required configuration keys
7. Verify `dotnet run` starts successfully and `GET /health` returns 200

## Current Project State

```
AiSmartReminder/
├── AiSmartReminder.sln
├── src/
│   ├── AiSmartReminder.Domain/
│   │   ├── AiSmartReminder.Domain.csproj
│   │   ├── Entities/
│   │   ├── Interfaces/
│   │   ├── Enums/
│   │   └── ValueObjects/
│   ├── AiSmartReminder.Application/
│   │   ├── AiSmartReminder.Application.csproj
│   │   ├── Services/
│   │   ├── DTOs/
│   │   ├── Interfaces/
│   │   └── Validators/
│   ├── AiSmartReminder.Infrastructure/
│   │   ├── AiSmartReminder.Infrastructure.csproj
│   │   ├── Persistence/
│   │   ├── Services/
│   │   └── Configuration/
│   └── AiSmartReminder.Api/
│       ├── AiSmartReminder.Api.csproj
│       ├── Program.cs (template-generated)
│       ├── Controllers/
│       ├── Middleware/
│       └── Filters/
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | src/AiSmartReminder.Application/DependencyInjection.cs | Static class with `AddApplicationServices()` extension method for `IServiceCollection` |
| CREATE | src/AiSmartReminder.Infrastructure/DependencyInjection.cs | Static class with `AddInfrastructureServices(IConfiguration)` extension method for `IServiceCollection` |
| MODIFY | src/AiSmartReminder.Api/Program.cs | Replace template code with production host configuration: DI, middleware pipeline, health checks, CORS |
| MODIFY | src/AiSmartReminder.Api/appsettings.json | Add required configuration sections with placeholder values |
| CREATE | src/AiSmartReminder.Api/appsettings.Development.json | Development-specific configuration overrides |

## External References

- [ASP.NET Core 8.0 Health Checks](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-8.0)
- [ASP.NET Core 8.0 Dependency Injection](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0)
- [ASP.NET Core 8.0 Middleware Pipeline](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0)
- [Options Pattern Validation in .NET 8](https://learn.microsoft.com/en-us/dotnet/core/extensions/options-validation)

## Build Commands

```bash
dotnet build AiSmartReminder.sln
dotnet run --project src/AiSmartReminder.Api
curl http://localhost:5000/health
```

## Implementation Validation Strategy

- [x] `dotnet build AiSmartReminder.sln` completes with zero errors
- [x] `dotnet run --project src/AiSmartReminder.Api` starts without exceptions
- [x] `GET /health` returns HTTP 200 with JSON body confirming healthy status
- [x] Removing a required configuration key from appsettings.json causes a descriptive startup exception listing the missing key
- [x] `DependencyInjection.cs` exists in both Application and Infrastructure projects

## Implementation Checklist

- [x] Create `DependencyInjection.cs` in Application project with `AddApplicationServices()` extension method
- [x] Create `DependencyInjection.cs` in Infrastructure project with `AddInfrastructureServices(IConfiguration)` extension method
- [x] Configure `Program.cs` with service registrations, health checks, controllers, CORS, and middleware pipeline
- [x] Map `/health` endpoint returning 200 OK with JSON health status
- [x] Configure `appsettings.json` with required sections (ConnectionStrings, JwtSettings) using placeholder values
- [x] Implement startup configuration validation that throws descriptive exception for missing required keys
- [x] Verify `dotnet run` starts and `GET /health` returns 200 OK
