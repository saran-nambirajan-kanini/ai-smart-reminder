# Task - task_001_fe_angular_project_setup

## Requirement Reference

- User Story: us_002
- Story Location: .propel/context/tasks/EP-TECH/us_002/us_002.md
- Acceptance Criteria:
  - Given the Angular CLI is available, When the project is created, Then it MUST use Angular 18+ with strict TypeScript configuration enabled.
  - Given the project is created, When running `ng serve`, Then the application MUST compile without errors and render a default landing page in the browser.
- Edge Case:
  - How does the system handle missing environment configuration? The application MUST display a clear error message when required environment variables are not set.

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
| Frontend | Angular | 18+ |
| Frontend | TypeScript | 5.4+ (strict mode) |
| Frontend | Angular CLI | 18+ |
| Frontend | Node.js | 20.x LTS |

**Note**: All code, and libraries, MUST be compatible with versions above.

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

Create the Angular 18+ project using Angular CLI with strict TypeScript configuration enabled. Configure environment files for development and production with runtime validation that displays clear error messages when required environment variables are missing. Set up the foundational project structure, install base dependencies, and verify the application compiles and serves without errors.

## Dependent Tasks

- None (this is the first task in US_002)

## Impacted Components

- NEW: `src/AiSmartReminder.Web/` — Angular 18+ frontend project root
- NEW: `src/AiSmartReminder.Web/src/environments/` — Environment configuration files
- NEW: `src/AiSmartReminder.Web/src/app/app.config.ts` — Application configuration (standalone)
- NEW: `src/AiSmartReminder.Web/src/app/app.component.ts` — Root application component

## Implementation Plan

1. Install Angular CLI globally (or verify version >= 18)
2. Generate new Angular project using `ng new` with `--strict` flag, standalone components (Angular 18+ default), and routing enabled
3. Configure `tsconfig.json` with strict TypeScript settings (`strict: true`, `noImplicitReturns: true`, `noFallthroughCasesInSwitch: true`, `noUnusedLocals: true`, `noUnusedParameters: true`)
4. Create environment configuration files (`environment.ts`, `environment.development.ts`) with typed interface
5. Implement runtime environment validator service that checks for required configuration values and throws a clear error message on missing values
6. Configure `angular.json` file replacements for environment-based builds
7. Verify `ng serve` compiles without errors and renders the default page

**Focus on how to implement**

## Current Project State

```
src/
├── AiSmartReminder.Api/
├── AiSmartReminder.Application/
├── AiSmartReminder.Domain/
└── AiSmartReminder.Infrastructure/
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | src/AiSmartReminder.Web/ | Angular 18+ project root directory |
| CREATE | src/AiSmartReminder.Web/angular.json | Angular workspace configuration with strict settings |
| CREATE | src/AiSmartReminder.Web/tsconfig.json | TypeScript strict configuration |
| CREATE | src/AiSmartReminder.Web/tsconfig.app.json | App-specific TS config extending base |
| CREATE | src/AiSmartReminder.Web/package.json | Node dependencies and scripts |
| CREATE | src/AiSmartReminder.Web/src/environments/environment.ts | Production environment config |
| CREATE | src/AiSmartReminder.Web/src/environments/environment.development.ts | Development environment config |
| CREATE | src/AiSmartReminder.Web/src/app/app.config.ts | Application bootstrap configuration |
| CREATE | src/AiSmartReminder.Web/src/app/app.component.ts | Root component (standalone) |
| CREATE | src/AiSmartReminder.Web/src/app/app.routes.ts | Root routing configuration |

## External References

- [Angular CLI Reference - ng new](https://angular.dev/tools/cli/setup-local)
- [Angular Strict Mode](https://angular.dev/tools/cli/template-typecheck#strict-mode)
- [Angular Environment Configuration](https://angular.dev/tools/cli/environments)
- [TypeScript Strict Compiler Options](https://www.typescriptlang.org/tsconfig#strict)

## Build Commands

```bash
# Install Angular CLI
npm install -g @angular/cli@18

# Create project
ng new AiSmartReminder.Web --strict --routing --style=scss --standalone

# Serve application
cd src/AiSmartReminder.Web
ng serve
```

## Implementation Validation Strategy

- [ ] `ng serve` compiles without errors
- [ ] Default landing page renders in browser at http://localhost:4200
- [ ] `tsconfig.json` has `"strict": true` and all strict sub-options enabled
- [ ] Angular version in `package.json` is 18+
- [ ] Environment files exist with typed interface
- [ ] Missing environment variable triggers clear error message in console
- [ ] `ng build --configuration production` completes without errors

## Implementation Checklist

- [ ] Install/verify Angular CLI version >= 18
- [ ] Generate Angular project with `--strict --routing --style=scss --standalone` flags
- [ ] Verify and harden `tsconfig.json` strict settings (noImplicitReturns, noFallthroughCasesInSwitch, noUnusedLocals, noUnusedParameters)
- [ ] Create typed environment interface and environment files (development, production)
- [ ] Implement environment validator that throws descriptive error on missing required config values
- [ ] Configure `angular.json` file replacements for production builds
- [ ] Run `ng serve` and verify clean compilation with default page rendering
