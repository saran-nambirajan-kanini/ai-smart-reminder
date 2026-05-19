# Task - task_001_be_solution_structure

## Requirement Reference

- User Story: US_001
- Story Location: .propel/context/tasks/EP-TECH/us_001/us_001.md
- Acceptance Criteria:
  - AC-1: Given the development environment is ready, When the solution is created, Then there MUST be four distinct projects: Domain (zero external dependencies), Application (references Domain only), Infrastructure (references Application), and Presentation/API (references Application and Infrastructure).
  - AC-2: Given the Clean Architecture layers exist, When building the solution, Then the Domain project MUST NOT reference Application, Infrastructure, or Presentation projects.
  - AC-5: Given the Domain layer is created, When inspecting its contents, Then it MUST contain folders for Entities, Interfaces, Enums, and ValueObjects.
- Edge Case:
  - EC-1: What happens when a developer accidentally adds an Infrastructure reference to the Domain project? Build MUST fail via architectural test or analyzer rule enforcing dependency direction.

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

Create the .NET 8 solution file and four Clean Architecture projects (Domain, Application, Infrastructure, Presentation) with strict dependency inversion. Configure project references so inner layers never depend on outer layers. Establish the canonical folder structure within each project.

## Dependent Tasks

- None (this is the foundational task for all backend development)

## Impacted Components

- NEW: `AiSmartReminder.sln` — Solution file
- NEW: `src/AiSmartReminder.Domain/AiSmartReminder.Domain.csproj` — Domain layer project
- NEW: `src/AiSmartReminder.Application/AiSmartReminder.Application.csproj` — Application layer project
- NEW: `src/AiSmartReminder.Infrastructure/AiSmartReminder.Infrastructure.csproj` — Infrastructure layer project
- NEW: `src/AiSmartReminder.Api/AiSmartReminder.Api.csproj` — Presentation/API layer project

## Implementation Plan

1. Create the solution file `AiSmartReminder.sln` at the repository root
2. Create Domain project with `net8.0` target, zero NuGet packages, zero project references
3. Create Application project with `net8.0` target, referencing Domain only
4. Create Infrastructure project with `net8.0` target, referencing Application (which transitively includes Domain)
5. Create Presentation/API project (`webapi` template) with `net8.0` target, referencing Application and Infrastructure
6. Scaffold Domain folders: `Entities/`, `Interfaces/`, `Enums/`, `ValueObjects/`, `Exceptions/`
7. Scaffold Application folders: `Services/`, `DTOs/`, `Interfaces/`, `Validators/`, `Common/`
8. Scaffold Infrastructure folders: `Persistence/`, `Services/`, `Configuration/`
9. Scaffold API folders: `Controllers/`, `Middleware/`, `Filters/`
10. Add `.gitkeep` files in empty directories so folder structure persists in version control
11. Verify `dotnet build` succeeds with zero warnings

## Current Project State

```
AiSmartReminder/
├── .propel/
├── .github/
├── docs/
├── README.md
└── (no src/ directory yet)
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | AiSmartReminder.sln | Solution file referencing all 4 projects |
| CREATE | src/AiSmartReminder.Domain/AiSmartReminder.Domain.csproj | Domain layer — zero external references, `net8.0`, nullable enabled, implicit usings |
| CREATE | src/AiSmartReminder.Domain/Entities/.gitkeep | Entities folder placeholder |
| CREATE | src/AiSmartReminder.Domain/Interfaces/.gitkeep | Interfaces folder placeholder |
| CREATE | src/AiSmartReminder.Domain/Enums/.gitkeep | Enums folder placeholder |
| CREATE | src/AiSmartReminder.Domain/ValueObjects/.gitkeep | Value objects folder placeholder |
| CREATE | src/AiSmartReminder.Domain/Exceptions/.gitkeep | Domain exceptions folder placeholder |
| CREATE | src/AiSmartReminder.Application/AiSmartReminder.Application.csproj | Application layer — references Domain only |
| CREATE | src/AiSmartReminder.Application/Services/.gitkeep | Application services folder |
| CREATE | src/AiSmartReminder.Application/DTOs/.gitkeep | Data transfer objects folder |
| CREATE | src/AiSmartReminder.Application/Interfaces/.gitkeep | Application interfaces (ports) folder |
| CREATE | src/AiSmartReminder.Application/Validators/.gitkeep | Input validators folder |
| CREATE | src/AiSmartReminder.Application/Common/.gitkeep | Common abstractions folder |
| CREATE | src/AiSmartReminder.Infrastructure/AiSmartReminder.Infrastructure.csproj | Infrastructure layer — references Application |
| CREATE | src/AiSmartReminder.Infrastructure/Persistence/.gitkeep | EF Core DbContext and repos folder |
| CREATE | src/AiSmartReminder.Infrastructure/Services/.gitkeep | External service adapters folder |
| CREATE | src/AiSmartReminder.Infrastructure/Configuration/.gitkeep | Configuration bindings folder |
| CREATE | src/AiSmartReminder.Api/AiSmartReminder.Api.csproj | Presentation layer — references Application and Infrastructure |
| CREATE | src/AiSmartReminder.Api/Controllers/.gitkeep | API controllers folder |
| CREATE | src/AiSmartReminder.Api/Middleware/.gitkeep | Custom middleware folder |
| CREATE | src/AiSmartReminder.Api/Filters/.gitkeep | Action filters folder |

## External References

- [.NET 8 SDK — Official Documentation](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
- [Clean Architecture with .NET — Jason Taylor Template](https://github.com/jasontaylordev/CleanArchitecture)
- [ASP.NET Core Project Structure](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/)

## Build Commands

```bash
dotnet new sln -n AiSmartReminder
dotnet new classlib -n AiSmartReminder.Domain -o src/AiSmartReminder.Domain
dotnet new classlib -n AiSmartReminder.Application -o src/AiSmartReminder.Application
dotnet new classlib -n AiSmartReminder.Infrastructure -o src/AiSmartReminder.Infrastructure
dotnet new webapi -n AiSmartReminder.Api -o src/AiSmartReminder.Api --no-https false
dotnet sln add src/AiSmartReminder.Domain
dotnet sln add src/AiSmartReminder.Application
dotnet sln add src/AiSmartReminder.Infrastructure
dotnet sln add src/AiSmartReminder.Api
dotnet add src/AiSmartReminder.Application reference src/AiSmartReminder.Domain
dotnet add src/AiSmartReminder.Infrastructure reference src/AiSmartReminder.Application
dotnet add src/AiSmartReminder.Api reference src/AiSmartReminder.Application
dotnet add src/AiSmartReminder.Api reference src/AiSmartReminder.Infrastructure
dotnet build AiSmartReminder.sln
```

## Implementation Validation Strategy

- [x] `dotnet build AiSmartReminder.sln` completes with zero errors and zero warnings
- [x] Domain.csproj contains zero `<ProjectReference>` and zero `<PackageReference>` elements
- [x] Application.csproj contains exactly one `<ProjectReference>` to Domain
- [x] Infrastructure.csproj contains exactly one `<ProjectReference>` to Application
- [x] Api.csproj contains two `<ProjectReference>` entries: Application and Infrastructure
- [x] Domain project contains folders: Entities, Interfaces, Enums, ValueObjects

## Implementation Checklist

- [x] Create solution file `AiSmartReminder.sln` at repository root
- [x] Create `src/AiSmartReminder.Domain` class library (`net8.0`, nullable enabled, implicit usings)
- [x] Create `src/AiSmartReminder.Application` class library referencing Domain only
- [x] Create `src/AiSmartReminder.Infrastructure` class library referencing Application
- [x] Create `src/AiSmartReminder.Api` web API project referencing Application and Infrastructure
- [x] Scaffold folder structure in all four projects with `.gitkeep` placeholders
- [x] Verify `dotnet build` passes with zero errors and zero warnings
