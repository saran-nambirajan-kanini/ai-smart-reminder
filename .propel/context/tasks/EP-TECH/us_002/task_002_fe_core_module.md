# Task - task_002_fe_core_module

## Requirement Reference

- User Story: us_002
- Story Location: .propel/context/tasks/EP-TECH/us_002/us_002.md
- Acceptance Criteria:
  - Given the project is scaffolded, When inspecting the module structure, Then there MUST be a CoreModule (for singleton services, auth, HTTP interceptors).
- Edge Case:
  - What happens when a developer imports CoreModule in a Feature module? A runtime guard MUST throw an error preventing CoreModule from being imported more than once.

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
| Frontend | RxJS | 7.x |

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

Implement the CoreModule as an Angular NgModule containing singleton services, authentication service stubs, and HTTP interceptors. The module MUST include a runtime import guard (`throwIfAlreadyLoaded`) that prevents CoreModule from being imported in any module other than the root AppModule. This ensures singleton services remain singleton throughout the application lifecycle.

## Dependent Tasks

- task_001_fe_angular_project_setup (Angular project must exist)

## Impacted Components

- NEW: `src/AiSmartReminder.Web/src/app/core/core.module.ts` — CoreModule with import guard
- NEW: `src/AiSmartReminder.Web/src/app/core/guards/module-import.guard.ts` — throwIfAlreadyLoaded function
- NEW: `src/AiSmartReminder.Web/src/app/core/interceptors/http-error.interceptor.ts` — Global HTTP error interceptor
- NEW: `src/AiSmartReminder.Web/src/app/core/interceptors/auth.interceptor.ts` — JWT auth token interceptor
- NEW: `src/AiSmartReminder.Web/src/app/core/services/auth.service.ts` — Authentication service stub
- MODIFY: `src/AiSmartReminder.Web/src/app/app.config.ts` — Register CoreModule providers and interceptors

## Implementation Plan

1. Create `src/app/core/` directory structure with subdirectories: `guards/`, `interceptors/`, `services/`
2. Implement `throwIfAlreadyLoaded` guard function that checks if a module's parent injector already has the module and throws a descriptive runtime error
3. Create `CoreModule` NgModule class that calls `throwIfAlreadyLoaded` in its constructor
4. Implement `AuthInterceptor` as a functional HTTP interceptor that attaches JWT bearer token from storage to outgoing API requests
5. Implement `HttpErrorInterceptor` as a functional HTTP interceptor that catches HTTP errors and provides standardized error handling
6. Create `AuthService` stub with login/logout/isAuthenticated interface methods
7. Register interceptors via `provideHttpClient(withInterceptors([...]))` in `app.config.ts`
8. Export a barrel `index.ts` from `core/` for clean imports

**Focus on how to implement**

## Current Project State

```
src/AiSmartReminder.Web/
├── angular.json
├── tsconfig.json
├── package.json
└── src/
    ├── environments/
    │   ├── environment.ts
    │   └── environment.development.ts
    └── app/
        ├── app.config.ts
        ├── app.component.ts
        └── app.routes.ts
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | src/AiSmartReminder.Web/src/app/core/core.module.ts | CoreModule with import guard in constructor |
| CREATE | src/AiSmartReminder.Web/src/app/core/guards/module-import.guard.ts | throwIfAlreadyLoaded utility function |
| CREATE | src/AiSmartReminder.Web/src/app/core/interceptors/auth.interceptor.ts | Functional interceptor for JWT token attachment |
| CREATE | src/AiSmartReminder.Web/src/app/core/interceptors/http-error.interceptor.ts | Functional interceptor for HTTP error handling |
| CREATE | src/AiSmartReminder.Web/src/app/core/services/auth.service.ts | Singleton auth service stub |
| CREATE | src/AiSmartReminder.Web/src/app/core/index.ts | Barrel export file |
| MODIFY | src/AiSmartReminder.Web/src/app/app.config.ts | Add provideHttpClient with interceptors registration |

## External References

- [Angular HTTP Interceptors (Functional)](https://angular.dev/guide/http/interceptors)
- [Angular Dependency Injection - Singleton Services](https://angular.dev/guide/ngmodules/singleton-services)
- [Angular Module Import Guard Pattern](https://angular.dev/guide/ngmodules/singleton-services#prevent-reimport-of-the-greetingmodule)

## Build Commands

```bash
cd src/AiSmartReminder.Web
ng serve
```

## Implementation Validation Strategy

- [ ] CoreModule exists at `src/app/core/core.module.ts`
- [ ] Importing CoreModule a second time throws a descriptive runtime error
- [ ] AuthInterceptor attaches Authorization header to outgoing requests
- [ ] HttpErrorInterceptor catches and processes HTTP errors
- [ ] AuthService is provided as singleton (root-level)
- [ ] `ng serve` compiles without errors after changes
- [ ] No circular dependency warnings in build output

## Implementation Checklist

- [ ] Create `core/` directory with `guards/`, `interceptors/`, `services/` subdirectories
- [ ] Implement `throwIfAlreadyLoaded(parentModule, moduleName)` guard function
- [ ] Create CoreModule class with import guard invocation in constructor
- [ ] Implement functional `authInterceptor` that reads token from storage and adds Bearer header
- [ ] Implement functional `httpErrorInterceptor` with standardized error logging and handling
- [ ] Create `AuthService` injectable stub with `login()`, `logout()`, `isAuthenticated()` methods
- [ ] Register interceptors in `app.config.ts` via `provideHttpClient(withInterceptors([...]))`
- [ ] Create barrel `index.ts` exporting all public core APIs
