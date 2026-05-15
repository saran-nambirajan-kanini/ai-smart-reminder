---
post_title: "AI Smart Reminder - Information Architecture"
author1: "AI Product Designer"
post_slug: "ai-smart-reminder-ia"
categories: ["wireframes", "information-architecture"]
tags: ["ai", "task-management", "angular", "responsive", "navigation"]
ai_note: "Generated from figma_spec.md screen inventory and prototype flows"
summary: "Information architecture for the AI Smart Reminder application documenting site hierarchy, navigation patterns, screen references, and user flows for 19 screens serving 2 personas."
post_date: "2026-05-14"
---

# Information Architecture - AI Smart Reminder

## 1. Wireframe Specification

**Fidelity Level**: High
**Screen Type**: Responsive (Desktop primary, Tablet + Mobile adaptive)
**Viewport**: 1440x900px (Desktop), 768x1024px (Tablet), 375x812px (Mobile)

## 2. System Overview

AI Smart Reminder is an AI-powered to-do list and reminder application delivered as a responsive Angular 18+ SPA. The system supports task CRUD operations, multi-channel reminders, AI-driven NLP task creation, smart prioritization, and productivity analytics. Two personas interact with the system: end Users (task management) and Admins (system management).

## 3. Wireframe References

### Generated Wireframes

**HTML Wireframes**:

| Screen/Feature | File Path | Description | Fidelity | Date Created |
|---------------|-----------|-------------|----------|--------------|
| SCR-001 Login | `./Hi-Fi/wireframe-SCR-001-login.html` | Email/password login with OAuth buttons | High | 2026-05-14 |
| SCR-002 Registration | `./Hi-Fi/wireframe-SCR-002-registration.html` | User registration form | High | 2026-05-14 |
| SCR-003 Password Reset Request | `./Hi-Fi/wireframe-SCR-003-password-reset-request.html` | Email input for password reset | High | 2026-05-14 |
| SCR-004 Password Reset Confirm | `./Hi-Fi/wireframe-SCR-004-password-reset-confirm.html` | New password form via email link | High | 2026-05-14 |
| SCR-005 User Profile | `./Hi-Fi/wireframe-SCR-005-user-profile.html` | Profile settings and notification preferences | High | 2026-05-14 |
| SCR-006 Task List | `./Hi-Fi/wireframe-SCR-006-task-list.html` | Filterable task list with search | High | 2026-05-14 |
| SCR-007 Task Detail | `./Hi-Fi/wireframe-SCR-007-task-detail.html` | Full task view with notes and reminders | High | 2026-05-14 |
| SCR-008 Task Create/Edit | `./Hi-Fi/wireframe-SCR-008-task-form.html` | Task creation/edit form with AI suggestions | High | 2026-05-14 |
| SCR-009 Reminder Create/Edit | `./Hi-Fi/wireframe-SCR-009-reminder-modal.html` | Reminder configuration modal | High | 2026-05-14 |
| SCR-010 Upcoming Reminders | `./Hi-Fi/wireframe-SCR-010-upcoming-reminders.html` | Sorted list of upcoming reminders | High | 2026-05-14 |
| SCR-011 AI Task Input | `./Hi-Fi/wireframe-SCR-011-ai-task-input.html` | Natural language task creation | High | 2026-05-14 |
| SCR-012 AI Priority View | `./Hi-Fi/wireframe-SCR-012-ai-priority.html` | AI-ranked task list with reasoning | High | 2026-05-14 |
| SCR-013 Dashboard | `./Hi-Fi/wireframe-SCR-013-dashboard.html` | Productivity metrics and analytics | High | 2026-05-14 |
| SCR-014 Notification Settings | `./Hi-Fi/wireframe-SCR-014-notification-settings.html` | Channel preferences and quiet hours | High | 2026-05-14 |
| SCR-015 Notification History | `./Hi-Fi/wireframe-SCR-015-notification-history.html` | Notification log with delivery status | High | 2026-05-14 |
| SCR-016 Admin Dashboard | `./Hi-Fi/wireframe-SCR-016-admin-dashboard.html` | System health metrics | High | 2026-05-14 |
| SCR-017 Admin User Management | `./Hi-Fi/wireframe-SCR-017-admin-users.html` | User account administration | High | 2026-05-14 |
| SCR-018 Admin Audit Log | `./Hi-Fi/wireframe-SCR-018-admin-audit-log.html` | Searchable audit log viewer | High | 2026-05-14 |
| SCR-019 Admin System Settings | `./Hi-Fi/wireframe-SCR-019-admin-settings.html` | System-wide configuration | High | 2026-05-14 |

### Component Inventory

**Reference**: See [Component Inventory](./component-inventory.md) for detailed component documentation.

## 4. User Personas & Flows

### Persona 1: User

- **Role**: Authenticated end user
- **Goals**: Create and manage tasks, set reminders, leverage AI suggestions, review productivity
- **Key Screens**: SCR-001 to SCR-015
- **Primary Flow**: Login (SCR-001) → Dashboard (SCR-013) → Task List (SCR-006) → Task Detail (SCR-007) → Set Reminder (SCR-009)
- **AI Flow**: Dashboard (SCR-013) → AI Task Input (SCR-011) → Task Detail (SCR-007)
- **Decision Points**: Accept/reject AI suggestions, choose notification channels, snooze vs dismiss reminders

### Persona 2: Admin

- **Role**: System administrator
- **Goals**: Manage users, monitor health, review audit trails, configure system
- **Key Screens**: SCR-001, SCR-016 to SCR-019
- **Primary Flow**: Login (SCR-001) → Admin Dashboard (SCR-016) → User Management (SCR-017) → Audit Log (SCR-018)
- **Decision Points**: Activate/deactivate users, adjust rate limits, configure AI parameters

### User Flow Diagrams

- **FL-001 Authentication**: SCR-001 → SCR-002/SCR-003/SCR-004 → SCR-013
- **FL-002 Manual Task Creation**: SCR-006 → SCR-008 → SCR-007
- **FL-003 NL Task Creation**: SCR-011 → SCR-007/SCR-008
- **FL-004 Reminder & Notification**: SCR-007 → SCR-009 → SCR-015
- **FL-005 Analytics**: SCR-013 (standalone with drill-down to SCR-006)
- **FL-006 Notification Management**: SCR-014 ↔ SCR-015
- **FL-007 Admin Management**: SCR-016 → SCR-017/SCR-018/SCR-019
- **FL-008 Task Prioritization**: SCR-012 → SCR-007
- **FL-009 Error Recovery**: Any screen/Error → Retry → Default state

## 5. Screen Hierarchy

### Level 1: Authentication (Unauthenticated)

- **SCR-001 Login** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-001-login.html]
  - Description: Entry point for all users; email/password + OAuth login
  - User Entry Point: Yes
  - Key Components: TextField (2), Button (2), Link (2), SocialButton (2), Divider (1)

- **SCR-002 Registration** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-002-registration.html]
  - Description: New user account creation
  - Parent Screen: SCR-001
  - Key Components: TextField (3), Button (1), Link (1)

- **SCR-003 Password Reset Request** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-003-password-reset-request.html]
  - Description: Initiate password reset via email
  - Parent Screen: SCR-001
  - Key Components: TextField (1), Button (1), Link (1)

- **SCR-004 Password Reset Confirm** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-004-password-reset-confirm.html]
  - Description: Set new password after email link
  - Parent Screen: SCR-003
  - Key Components: TextField (2), Button (1)

### Level 2: Main Application (User Role)

- **SCR-013 Dashboard** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-013-dashboard.html]
  - Description: User landing page with productivity metrics and AI insights
  - User Entry Point: Yes (after login)
  - Key Components: Card (5), Chart (3), ListItem (N), Card (N)

- **SCR-006 Task List** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-006-task-list.html]
  - Description: Filterable, searchable task list with priority badges
  - Parent Screen: SCR-013 (via sidebar)
  - Key Components: Card (N), SearchField (1), Select (4), Button (2), Tag (N), Badge (N), Pagination (1)

- **SCR-007 Task Detail** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-007-task-detail.html]
  - Description: Full task view with notes, reminders, and actions
  - Parent Screen: SCR-006
  - Key Components: Card (1), Badge (2), Button (3), ListItem (N)

- **SCR-008 Task Create/Edit** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-008-task-form.html]
  - Description: Task form with AI suggestion integration
  - Parent Screen: SCR-006 or SCR-011
  - Key Components: TextField (2), DatePicker (1), Select (2), TextArea (1), Button (2), Alert (1)

- **SCR-011 AI Task Input** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-011-ai-task-input.html]
  - Description: Natural language task creation with AI parsing
  - Parent Screen: SCR-013 (via nav/header shortcut)
  - Key Components: TextArea (1), Button (1), Card (1), Button (2), Skeleton (1)

- **SCR-009 Reminder Create/Edit** (P0 - Critical) - [Wireframe: Hi-Fi/wireframe-SCR-009-reminder-modal.html]
  - Description: Reminder configuration modal overlay
  - Parent Screen: SCR-007
  - Key Components: DatePicker (1), TimePicker (1), Select (1), TextField (1), Toggle (1), Button (2)

- **SCR-005 User Profile** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-005-user-profile.html]
  - Description: Profile management and notification preferences
  - Key Components: TextField (2), Toggle (3), TimePicker (2), Button (2)

- **SCR-010 Upcoming Reminders** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-010-upcoming-reminders.html]
  - Description: Chronologically sorted reminder list
  - Key Components: ListItem (N), Badge (N), Button (N)

- **SCR-012 AI Priority View** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-012-ai-priority.html]
  - Description: AI-ranked task list with reasoning explanations
  - Key Components: ListItem (N), Card (N), Badge (N), Alert (1)

- **SCR-014 Notification Settings** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-014-notification-settings.html]
  - Description: Channel preferences and quiet hours configuration
  - Key Components: Toggle (3), TimePicker (2), Button (1)

- **SCR-015 Notification History** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-015-notification-history.html]
  - Description: Notification log with delivery status and bulk actions
  - Key Components: ListItem (N), Badge (N), Checkbox (N), Button (2)

### Level 3: Admin Panel (Admin Role)

- **SCR-016 Admin Dashboard** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-016-admin-dashboard.html]
  - Description: System health metrics and status overview
  - User Entry Point: Yes (admin landing after login)
  - Key Components: Card (4), Table (1), Badge (N)

- **SCR-017 Admin User Management** (P1 - High) - [Wireframe: Hi-Fi/wireframe-SCR-017-admin-users.html]
  - Description: User account administration with search
  - Parent Screen: SCR-016
  - Key Components: Table (1), SearchField (1), Button (N), Badge (N)

- **SCR-018 Admin Audit Log** (P2 - Medium) - [Wireframe: Hi-Fi/wireframe-SCR-018-admin-audit-log.html]
  - Description: Searchable, filterable audit trail viewer
  - Parent Screen: SCR-016
  - Key Components: Table (1), SearchField (1), Select (3), Pagination (1)

- **SCR-019 Admin System Settings** (P2 - Medium) - [Wireframe: Hi-Fi/wireframe-SCR-019-admin-settings.html]
  - Description: System-wide configuration parameters
  - Parent Screen: SCR-016
  - Key Components: TextField (N), Toggle (N), Button (2)

### Screen Priority Legend

- **P0**: Critical path screens (must-have for MVP)
- **P1**: High-priority screens (core functionality)
- **P2**: Medium-priority screens (important features)

### Modal/Dialog/Overlay Inventory

| Modal/Dialog Name | Type | Trigger Context | Parent Screen | Wireframe Reference | Priority |
|------------------|------|----------------|---------------|-------------------|----------|
| Reminder Create/Edit | Modal | Click "Add Reminder" / "Edit Reminder" | SCR-007 | `./Hi-Fi/wireframe-SCR-009-reminder-modal.html` | P0 |
| Delete Confirmation | Dialog | Click "Delete" on task or reminder | SCR-006, SCR-007 | Inline in parent wireframe | P0 |
| Snooze Reminder | Dialog | Click "Snooze" on notification | SCR-015, Toast | Inline in parent wireframe | P1 |
| AI Suggestion Panel | Inline Panel | AI returns suggestion | SCR-008, SCR-011 | Inline in parent wireframe | P0 |
| Disable All Channels Warning | Dialog | Disable all notification channels | SCR-014 | Inline in parent wireframe | P1 |
| Filter Drawer | Drawer | Click "Filters" on mobile | SCR-006, SCR-017, SCR-018 | Responsive variant in parent | P1 |

## 6. Navigation Architecture

```text
AI Smart Reminder
├── Login (wireframe-SCR-001-login.html)
│   ├── Register (wireframe-SCR-002-registration.html)
│   ├── Password Reset (wireframe-SCR-003-password-reset-request.html)
│   │   └── Reset Confirm (wireframe-SCR-004-password-reset-confirm.html)
│   └── [Login Success] → Dashboard
├── [User Authenticated]
│   ├── Dashboard (wireframe-SCR-013-dashboard.html) [Landing]
│   ├── Tasks
│   │   ├── Task List (wireframe-SCR-006-task-list.html)
│   │   ├── Task Detail (wireframe-SCR-007-task-detail.html)
│   │   │   └── Reminder Modal (wireframe-SCR-009-reminder-modal.html)
│   │   └── Task Form (wireframe-SCR-008-task-form.html)
│   ├── AI Input (wireframe-SCR-011-ai-task-input.html)
│   ├── AI Priority (wireframe-SCR-012-ai-priority.html)
│   ├── Reminders (wireframe-SCR-010-upcoming-reminders.html)
│   ├── Notifications
│   │   ├── History (wireframe-SCR-015-notification-history.html)
│   │   └── Settings (wireframe-SCR-014-notification-settings.html)
│   └── Profile (wireframe-SCR-005-user-profile.html)
└── [Admin Authenticated]
    ├── Admin Dashboard (wireframe-SCR-016-admin-dashboard.html) [Landing]
    ├── User Management (wireframe-SCR-017-admin-users.html)
    ├── Audit Log (wireframe-SCR-018-admin-audit-log.html)
    └── System Settings (wireframe-SCR-019-admin-settings.html)
```

### Navigation Patterns

- **Primary Navigation**: Sidebar (Desktop: 240px persistent; Tablet: 64px collapsed; Mobile: Bottom nav 5 items)
- **Secondary Navigation**: Breadcrumb (Desktop/Tablet), Back arrow + title (Mobile)
- **Utility Navigation**: Header bar with notification bell, AI shortcut, user avatar dropdown
- **Admin Navigation**: Separate sidebar section visible only to Admin role

## 7. Interaction Patterns

### Pattern 1: AI Task Creation (NL Input → Confirmation → Task)

- **Trigger**: User types natural language instruction
- **Flow**: Type → Parse (loading) → Review parsed result → Confirm/Edit → Task created
- **Screens Involved**: SCR-011, SCR-008, SCR-007
- **Feedback**: Skeleton during parsing; parsed card with accept/reject; success toast
- **Components Used**: TextArea, Button, Card, Skeleton, Toast

### Pattern 2: Reminder Configuration (Task → Modal → Notification)

- **Trigger**: User clicks "Add Reminder" on task detail
- **Flow**: Open modal → Set date/time/recurrence → Save → Reminder scheduled
- **Screens Involved**: SCR-007, SCR-009
- **Feedback**: Modal overlay; validation on past dates; success toast on save
- **Components Used**: Modal, DatePicker, TimePicker, Select, Toggle, Button, Toast

### Pattern 3: Filter and Search (List → Filter → Results)

- **Trigger**: User interacts with search field or filter controls
- **Flow**: Type query / select filters → Debounced API call → Results update
- **Screens Involved**: SCR-006, SCR-017, SCR-018
- **Feedback**: Inline loading indicator; result count update; empty state if no matches
- **Components Used**: SearchField, Select, Card/Table, Badge, Pagination

## 8. Error Handling

### Error Scenario 1: Network Error

- **Trigger**: API request fails or times out (> 10s)
- **Error Screen/State**: Error state with descriptive message and retry button
- **User Action**: Click "Try again" to retry the failed operation
- **Recovery Flow**: Error → Click Retry → Loading → Success/Error

### Error Scenario 2: AI Service Unavailable

- **Trigger**: AI circuit breaker open or timeout
- **Error Screen/State**: SCR-011/Error, SCR-012/Error with fallback message
- **User Action**: Use manual form (SCR-008) or view deterministic sort
- **Recovery Flow**: AI Error → "Create task manually" CTA → SCR-008

### Error Scenario 3: Session Timeout

- **Trigger**: JWT access token expired and refresh fails
- **Error Screen/State**: Modal overlay on any authenticated screen
- **User Action**: Re-authenticate; return URL preserves context
- **Recovery Flow**: Timeout modal → Login → Return to previous screen

## 9. Responsive Strategy

| Breakpoint | Width | Layout Changes | Navigation Changes | Component Adaptations |
|-----------|-------|----------------|-------------------|---------------------|
| Mobile | 375px | Single column, stacked cards | Bottom nav (5 items) | Full-width inputs, stacked buttons |
| Tablet | 768px | 2-column where appropriate | Collapsed sidebar (64px icons) | Adaptive card grid |
| Desktop | 1440px | Multi-column, sidebar + content | Persistent sidebar (240px) | Full-width tables, side-by-side panels |

## 10. Accessibility

### WCAG Compliance

- **Target Level**: AA
- **Color Contrast**: 4.5:1 for text, 3:1 for UI elements (validated via design tokens)
- **Keyboard Navigation**: Full keyboard support; Tab order follows reading order
- **Screen Reader Support**: Semantic HTML, ARIA labels, live regions for dynamic content

### Focus Order

- Auth screens: Email → Password → Submit → Links
- Forms: Top-to-bottom, left-to-right field order; error summary at top
- Modals: Focus trapped within; Escape to close; return focus on close
- Navigation: Skip link → Primary nav → Content → Secondary nav

## 11. Content Strategy

### Content Hierarchy

- **H1**: Page title (one per screen)
- **H2**: Section titles within page
- **H3**: Card/group titles
- **Body Text**: 14px default, 16px for primary content
- **Caption**: 12px for timestamps, badges, metadata

### Content Types by Screen

| Screen | Content Types | Notes |
|--------|--------------|-------|
| SCR-001 Login | Form, Links, Social buttons | Minimal content; focus on action |
| SCR-006 Task List | Cards, Badges, Search, Filters | Dynamic content; pagination |
| SCR-013 Dashboard | Metric cards, Charts, Lists, AI text | Data-heavy; above-the-fold metrics |
| SCR-011 AI Input | TextArea, AI-generated card | NL text in; structured data out |
