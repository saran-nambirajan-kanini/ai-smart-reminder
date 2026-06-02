# Task - task_004_fe_feature_module_routing

## Requirement Reference

- User Story: us_002
- Story Location: .propel/context/tasks/EP-TECH/us_002/us_002.md
- Acceptance Criteria:
  - Given the project is scaffolded, When inspecting the module structure, Then there MUST be at least one Feature module placeholder.
  - Given the project is created, When running `ng serve`, Then the application MUST compile without errors and render a default landing page in the browser.
  - Given the Angular project exists, When inspecting routing, Then there MUST be lazy-loaded route configuration for Feature modules.

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
| Frontend | Angular Router | 18+ |
| Frontend | Angular Material | 18+ |
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

Implement at least one Feature module placeholder (DashboardModule) with lazy-loaded route configuration. Create a default landing page component that renders when the application starts. Configure the Angular Router with lazy-loaded routes using `loadChildren` (for module-based) or `loadComponent` (for standalone) pattern. The routing setup demonstrates the scalable module pattern that future Feature modules will follow.

## Dependent Tasks

- task_001_fe_angular_project_setup (Angular project and routing must exist)
- task_003_fe_shared_module_material (SharedModule must exist for Feature modules to import)

## Impacted Components

- NEW: `src/AiSmartReminder.Web/src/app/features/dashboard/` — Dashboard Feature module directory
- NEW: `src/AiSmartReminder.Web/src/app/features/dashboard/dashboard.routes.ts` — Dashboard lazy-loaded routes
- NEW: `src/AiSmartReminder.Web/src/app/features/dashboard/pages/dashboard-page/dashboard-page.component.ts` — Dashboard landing page
- MODIFY: `src/AiSmartReminder.Web/src/app/app.routes.ts` — Add lazy-loaded route for Dashboard feature
- MODIFY: `src/AiSmartReminder.Web/src/app/app.component.ts` — Add router-outlet and basic navigation shell

## Implementation Plan

1. Create `src/app/features/` directory as the container for all Feature modules
2. Create `src/app/features/dashboard/` directory with `pages/` subdirectory
3. Create `DashboardPageComponent` as a standalone component that serves as the default landing page with a welcome message and basic layout using Angular Material components
4. Create `dashboard.routes.ts` with route definitions for the Dashboard feature
5. Update `app.routes.ts` to configure lazy-loaded route using `loadChildren(() => import('./features/dashboard/dashboard.routes').then(m => m.DASHBOARD_ROUTES))`
6. Add a default redirect from `''` to `'/dashboard'` in the root routes
7. Update `AppComponent` template to include `<router-outlet>` with a basic Material toolbar navigation shell
8. Verify lazy loading works by checking Network tab (dashboard chunk loaded on navigation)

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
        ├── core/
        │   ├── core.module.ts
        │   ├── guards/
        │   ├── interceptors/
        │   └── services/
        └── shared/
            ├── shared.module.ts
            ├── components/
            ├── pipes/
            └── directives/
```

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| CREATE | src/AiSmartReminder.Web/src/app/features/dashboard/dashboard.routes.ts | Dashboard feature route definitions |
| CREATE | src/AiSmartReminder.Web/src/app/features/dashboard/pages/dashboard-page/dashboard-page.component.ts | Default landing page component |
| CREATE | src/AiSmartReminder.Web/src/app/features/dashboard/pages/dashboard-page/dashboard-page.component.html | Landing page template with welcome content |
| CREATE | src/AiSmartReminder.Web/src/app/features/dashboard/pages/dashboard-page/dashboard-page.component.scss | Landing page styles |
| MODIFY | src/AiSmartReminder.Web/src/app/app.routes.ts | Add lazy-loaded route for dashboard feature with default redirect |
| MODIFY | src/AiSmartReminder.Web/src/app/app.component.ts | Add router-outlet and Material toolbar navigation |
| MODIFY | src/AiSmartReminder.Web/src/app/app.component.html | Add navigation shell with router-outlet |

## External References

- [Angular Lazy Loading Feature Modules](https://angular.dev/guide/ngmodules/lazy-loading-ngmodules)
- [Angular Router - loadChildren](https://angular.dev/api/router/LoadChildren)
- [Angular Standalone Components Routing](https://angular.dev/guide/routing/common-router-tasks)
- [Angular Material Toolbar](https://material.angular.io/components/toolbar/overview)

## Build Commands

```bash
cd src/AiSmartReminder.Web
ng serve
```

## Implementation Validation Strategy

- [ ] `ng serve` compiles without errors
- [ ] Default landing page renders at http://localhost:4200
- [ ] URL redirects from `/` to `/dashboard`
- [ ] Dashboard feature chunk is lazy-loaded (visible in browser Network tab as separate JS chunk)
- [ ] `features/dashboard/` directory structure exists
- [ ] Route configuration uses `loadChildren` or `loadComponent` pattern
- [ ] Navigation shell with Material toolbar renders correctly

## Implementation Checklist

- [ ] Create `features/` directory and `features/dashboard/pages/dashboard-page/` structure
- [ ] Implement `DashboardPageComponent` as standalone component with welcome content using Material card
- [ ] Create `dashboard.routes.ts` exporting `DASHBOARD_ROUTES` constant with route definitions
- [ ] Update `app.routes.ts` with lazy-loaded route: `loadChildren(() => import(...).then(m => m.DASHBOARD_ROUTES))`
- [ ] Add default redirect route from `''` to `/dashboard` with `pathMatch: 'full'`
- [ ] Update `AppComponent` to include Material toolbar and `<router-outlet>`
- [ ] Verify lazy loading in browser DevTools (Network tab shows separate chunk for dashboard)
