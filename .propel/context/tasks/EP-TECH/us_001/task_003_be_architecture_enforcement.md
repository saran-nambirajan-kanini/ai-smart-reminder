# Task - task_003_be_architecture_enforcement

## Requirement Reference

- User Story: US_001
- Story Location: .propel/context/tasks/EP-TECH/us_001/us_001.md
- Acceptance Criteria:
  - AC-2: Given the Clean Architecture layers exist, When building the solution, Then the Domain project MUST NOT reference Application, Infrastructure, or Presentation projects.
- Edge Case:
  - EC-1: What happens when a developer accidentally adds an Infrastructure reference to the Domain project? Build MUST fail via architectural test or analyzer rule enforcing dependency direction.
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
| Testing | xUnit + FluentAssertions | latest compatible with .NET 8 |
| Architecture Testing | NetArchTest.Rules | 1.3+ |

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

Implement architectural enforcement tests using NetArchTest.Rules to validate Clean Architecture dependency direction at build/test time. Any violation (e.g., Domain referencing Infrastructure) causes test failure, providing a safety net against accidental coupling. This ensures the structural integrity established in task_001 is maintained as the codebase grows.

## Dependent Tasks

- task_001_be_solution_structure — Requires all four projects to exist with correct references

## Impacted Components

- NEW: `tests/AiSmartReminder.Architecture.Tests/AiSmartReminder.Architecture.Tests.csproj` — Architecture test project
- NEW: `tests/AiSmartReminder.Architecture.Tests/ArchitectureTests.cs` — Dependency direction enforcement tests
- MODIFY: `AiSmartReminder.sln` — Add architecture test project to solution

## Implementation Plan

1. Create a new xUnit test project at `tests/AiSmartReminder.Architecture.Tests/`
2. Add NuGet packages: `NetArchTest.Rules`, `FluentAssertions`, `xUnit`, `xUnit.runner.visualstudio`
3. Add project references to all four source projects (to inspect their assemblies)
4. Implement architectural tests:
   - Domain MUST NOT depend on Application, Infrastructure, or Api namespaces
   - Application MUST NOT depend on Infrastructure or Api namespaces
   - Infrastructure MUST NOT depend on Api namespace
   - All interfaces in Domain.Interfaces MUST be interfaces (not classes)
5. Add the test project to the solution file
6. Run `dotnet test` to verify all architecture rules pass

## Current Project State

```
AiSmartReminder/
├── AiSmartReminder.sln
├── src/
│   ├── AiSmartReminder.Domain/
│   ├── AiSmartReminder.Application/
│   ├── AiSmartReminder.Infrastructure/
│   └── AiSmartReminder.Api/
└── (no tests/ directory yet)
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | tests/AiSmartReminder.Architecture.Tests/AiSmartReminder.Architecture.Tests.csproj | xUnit test project with NetArchTest.Rules, FluentAssertions packages |
| CREATE | tests/AiSmartReminder.Architecture.Tests/ArchitectureTests.cs | Tests enforcing dependency direction: Domain→none, Application→Domain only, Infrastructure→Application only |
| MODIFY | AiSmartReminder.sln | Add `tests/AiSmartReminder.Architecture.Tests` project reference |

## External References

- [NetArchTest — Architecture Testing for .NET](https://github.com/BenMorris/NetArchTest)
- [Clean Architecture Enforcement with NetArchTest](https://www.milanjovanovic.tech/blog/enforcing-software-architecture-with-architecture-tests)
- [xUnit.net Documentation](https://xunit.net/)

## Build Commands

```bash
dotnet new xunit -n AiSmartReminder.Architecture.Tests -o tests/AiSmartReminder.Architecture.Tests
dotnet sln add tests/AiSmartReminder.Architecture.Tests
dotnet add tests/AiSmartReminder.Architecture.Tests package NetArchTest.Rules
dotnet add tests/AiSmartReminder.Architecture.Tests package FluentAssertions
dotnet add tests/AiSmartReminder.Architecture.Tests reference src/AiSmartReminder.Domain
dotnet add tests/AiSmartReminder.Architecture.Tests reference src/AiSmartReminder.Application
dotnet add tests/AiSmartReminder.Architecture.Tests reference src/AiSmartReminder.Infrastructure
dotnet add tests/AiSmartReminder.Architecture.Tests reference src/AiSmartReminder.Api
dotnet test tests/AiSmartReminder.Architecture.Tests
```

## Implementation Validation Strategy

- [ ] `dotnet test tests/AiSmartReminder.Architecture.Tests` passes with all tests green
- [ ] Temporarily adding `<ProjectReference>` to Infrastructure in Domain.csproj causes the architecture test to FAIL
- [ ] Test names clearly describe which dependency rule is being enforced
- [ ] Test output provides actionable error messages listing violating types when a rule is broken

## Implementation Checklist

- [ ] Create `tests/AiSmartReminder.Architecture.Tests/` xUnit project with `net8.0` target
- [ ] Add NuGet packages: `NetArchTest.Rules`, `FluentAssertions`
- [ ] Add project references to Domain, Application, Infrastructure, and Api projects
- [ ] Implement test: Domain layer has no dependencies on Application, Infrastructure, or Api
- [ ] Implement test: Application layer has no dependencies on Infrastructure or Api
- [ ] Implement test: Infrastructure layer has no dependencies on Api
- [ ] Add test project to `AiSmartReminder.sln` and verify `dotnet test` passes
