# Task - task_003_fe_shared_module_material

## Requirement Reference

- User Story: us_002
- Story Location: .propel/context/tasks/EP-TECH/us_002/us_002.md
- Acceptance Criteria:
  - Given the project is scaffolded, When inspecting the module structure, Then there MUST be a SharedModule (for reusable components, pipes, directives).
  - Given the SharedModule exists, When inspecting its contents, Then it MUST export commonly used Angular Material or shared UI components.

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
| Frontend | Angular Material | 18+ |
| Frontend | Angular CDK | 18+ |
| Frontend | TypeScript | 5.4+ (strict mode) |

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

Implement the SharedModule containing reusable UI components, pipes, and directives that are shared across Feature modules. Install and configure Angular Material as the UI component library. The SharedModule MUST export commonly used Angular Material modules (MatButtonModule, MatCardModule, MatInputModule, MatIconModule, MatToolbarModule, MatSnackBarModule) and provide a centralized location for custom shared components, pipes, and directives used throughout the application.

## Dependent Tasks

- task_001_fe_angular_project_setup (Angular project must exist)

## Impacted Components

- NEW: `src/AiSmartReminder.Web/src/app/shared/shared.module.ts` — SharedModule exporting Material and shared components
- NEW: `src/AiSmartReminder.Web/src/app/shared/components/` — Shared UI components directory
- NEW: `src/AiSmartReminder.Web/src/app/shared/pipes/` — Shared pipes directory
- NEW: `src/AiSmartReminder.Web/src/app/shared/directives/` — Shared directives directory
- NEW: `src/AiSmartReminder.Web/src/app/shared/index.ts` — Barrel export file
- MODIFY: `src/AiSmartReminder.Web/src/styles.scss` — Import Angular Material theme

## Implementation Plan

1. Install Angular Material using `ng add @angular/material` with a pre-built theme (Indigo/Pink or custom)
2. Create `src/app/shared/` directory structure with `components/`, `pipes/`, `directives/` subdirectories
3. Create `SharedModule` NgModule that imports and re-exports commonly used Angular Material modules
4. Create a placeholder `LoadingSpinnerComponent` as an example shared component (standalone, exported by SharedModule)
5. Create a placeholder `TruncatePipe` as an example shared pipe
6. Configure Angular Material theme in `styles.scss` with typography and density settings
7. Create barrel `index.ts` for clean imports from `@shared`

**Focus on how to implement**

## Current Project State

```
src/AiSmartReminder.Web/
├── angular.json
├── tsconfig.json
├── package.json
└── src/
    ├── environments/
    ├── styles.scss
    └── app/
        ├── app.config.ts
        ├── app.component.ts
        ├── app.routes.ts
        └── core/
            ├── core.module.ts
            ├── guards/
            ├── interceptors/
            └── services/
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | src/AiSmartReminder.Web/src/app/shared/shared.module.ts | SharedModule with Material re-exports |
| CREATE | src/AiSmartReminder.Web/src/app/shared/components/loading-spinner/loading-spinner.component.ts | Example shared standalone component |
| CREATE | src/AiSmartReminder.Web/src/app/shared/pipes/truncate.pipe.ts | Example shared pipe |
| CREATE | src/AiSmartReminder.Web/src/app/shared/directives/.gitkeep | Placeholder for shared directives |
| CREATE | src/AiSmartReminder.Web/src/app/shared/index.ts | Barrel export file |
| MODIFY | src/AiSmartReminder.Web/src/styles.scss | Import Angular Material prebuilt theme and configure typography |
| MODIFY | src/AiSmartReminder.Web/package.json | Add @angular/material and @angular/cdk dependencies |

## External References

- [Angular Material Getting Started](https://material.angular.io/guide/getting-started)
- [Angular Material Theming](https://material.angular.io/guide/theming)
- [Angular Shared Modules Pattern](https://angular.dev/guide/ngmodules/sharing)
- [Angular Material Component Categories](https://material.angular.io/components/categories)

## Build Commands

```bash
cd src/AiSmartReminder.Web

# Install Angular Material
ng add @angular/material

# Verify build
ng serve
```

## Implementation Validation Strategy

- [ ] SharedModule exists at `src/app/shared/shared.module.ts`
- [ ] SharedModule exports Angular Material modules (MatButton, MatCard, MatInput, MatIcon, MatToolbar, MatSnackBar)
- [ ] Angular Material theme is configured and visible in the application
- [ ] LoadingSpinnerComponent exists and is exported from SharedModule
- [ ] TruncatePipe exists and is exported from SharedModule
- [ ] `ng serve` compiles without errors after changes
- [ ] Angular Material components render correctly in browser

## Implementation Checklist

- [ ] Install Angular Material via `ng add @angular/material` (select pre-built theme, set up typography, set up animations)
- [ ] Create `shared/` directory with `components/`, `pipes/`, `directives/` subdirectories
- [ ] Create SharedModule that imports and re-exports: MatButtonModule, MatCardModule, MatInputModule, MatFormFieldModule, MatIconModule, MatToolbarModule, MatSnackBarModule
- [ ] Create standalone `LoadingSpinnerComponent` with a Material progress spinner
- [ ] Create `TruncatePipe` (transforms long strings to truncated format with ellipsis)
- [ ] Configure Angular Material theme in `styles.scss` with proper `@use '@angular/material' as mat` syntax
- [ ] Create barrel `index.ts` exporting SharedModule and all public shared APIs
- [ ] Verify `ng serve` compiles without errors and Material styles render correctly
