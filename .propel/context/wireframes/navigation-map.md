---
post_title: "AI Smart Reminder - Navigation Map"
author1: "AI Product Designer"
post_slug: "ai-smart-reminder-navigation-map"
categories: ["wireframes", "navigation"]
tags: ["user-flows", "prototype-flows", "angular-router"]
ai_note: "Generated from figma_spec.md Section 11 prototype flows (FL-001 to FL-009)"
summary: "Cross-screen navigation index documenting all inter-screen links, triggers, and prototype flows for the AI Smart Reminder wireframe set."
post_date: "2026-05-14"
---

# Navigation Map - AI Smart Reminder

## 1. Overview

This document defines all navigable links between the 19 wireframes. Each link is wired in the HTML wireframes as clickable `<a>` elements pointing to sibling files.

## 2. Flow Index

| Flow ID | Name | Screens | Description |
|---------|------|---------|-------------|
| FL-001 | Authentication | SCR-001, SCR-002, SCR-003, SCR-004, SCR-013 | Login, register, password reset |
| FL-002 | Manual Task Creation | SCR-006, SCR-008, SCR-007 | Create task from list |
| FL-003 | NL Task Creation | SCR-011, SCR-007, SCR-008 | AI natural language task input |
| FL-004 | Reminder Setup | SCR-007, SCR-009 | Add/edit reminder from task |
| FL-005 | Analytics | SCR-013, SCR-006 | Dashboard drill-down to tasks |
| FL-006 | Notification Management | SCR-014, SCR-015 | Settings ↔ history toggle |
| FL-007 | Admin Management | SCR-016, SCR-017, SCR-018, SCR-019 | Admin CRUD flows |
| FL-008 | Task Prioritization | SCR-012, SCR-007 | AI priority → task detail |
| FL-009 | Error Recovery | Any, Error State | Retry/fallback patterns |

## 3. Navigation Matrix

### 3.1 Authentication Flow (FL-001)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-001 Login | "Sign In" button (valid) | Submit form | SCR-013 Dashboard | `wireframe-SCR-013-dashboard.html` |
| SCR-001 Login | "Create account" link | Click | SCR-002 Registration | `wireframe-SCR-002-registration.html` |
| SCR-001 Login | "Forgot password?" link | Click | SCR-003 Password Reset | `wireframe-SCR-003-password-reset-request.html` |
| SCR-002 Registration | "Sign Up" button (valid) | Submit form | SCR-013 Dashboard | `wireframe-SCR-013-dashboard.html` |
| SCR-002 Registration | "Sign in" link | Click | SCR-001 Login | `wireframe-SCR-001-login.html` |
| SCR-003 Password Reset | "Send reset link" button | Submit form | SCR-004 Confirm (info shown) | `wireframe-SCR-004-password-reset-confirm.html` |
| SCR-003 Password Reset | "Back to login" link | Click | SCR-001 Login | `wireframe-SCR-001-login.html` |
| SCR-004 Reset Confirm | "Reset password" button | Submit form | SCR-001 Login | `wireframe-SCR-001-login.html` |

### 3.2 Manual Task Creation (FL-002)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-006 Task List | "+ New Task" button | Click | SCR-008 Task Form | `wireframe-SCR-008-task-form.html` |
| SCR-006 Task List | Task card click | Click | SCR-007 Task Detail | `wireframe-SCR-007-task-detail.html` |
| SCR-008 Task Form | "Save" button (valid) | Submit | SCR-007 Task Detail | `wireframe-SCR-007-task-detail.html` |
| SCR-008 Task Form | "Cancel" button | Click | SCR-006 Task List | `wireframe-SCR-006-task-list.html` |

### 3.3 NL Task Creation (FL-003)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-011 AI Input | "Confirm" button (accept AI parse) | Click | SCR-007 Task Detail | `wireframe-SCR-007-task-detail.html` |
| SCR-011 AI Input | "Edit" button (modify AI parse) | Click | SCR-008 Task Form | `wireframe-SCR-008-task-form.html` |

### 3.4 Reminder Setup (FL-004)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-007 Task Detail | "Add Reminder" button | Click | SCR-009 Reminder Modal | `wireframe-SCR-009-reminder-modal.html` |
| SCR-009 Reminder Modal | "Save" button | Click (close modal) | SCR-007 Task Detail | `wireframe-SCR-007-task-detail.html` |
| SCR-009 Reminder Modal | "Cancel" / backdrop click | Click | SCR-007 Task Detail | `wireframe-SCR-007-task-detail.html` |

### 3.5 Analytics (FL-005)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-013 Dashboard | "View all tasks" or metric card click | Click | SCR-006 Task List | `wireframe-SCR-006-task-list.html` |

### 3.6 Notification Management (FL-006)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-014 Settings | "View History" tab/link | Click | SCR-015 Notification History | `wireframe-SCR-015-notification-history.html` |
| SCR-015 History | "Settings" tab/link | Click | SCR-014 Notification Settings | `wireframe-SCR-014-notification-settings.html` |

### 3.7 Admin Management (FL-007)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-016 Admin Dashboard | "User Management" card/link | Click | SCR-017 Admin Users | `wireframe-SCR-017-admin-users.html` |
| SCR-016 Admin Dashboard | "Audit Log" card/link | Click | SCR-018 Admin Audit | `wireframe-SCR-018-admin-audit-log.html` |
| SCR-016 Admin Dashboard | "Settings" card/link | Click | SCR-019 Admin Settings | `wireframe-SCR-019-admin-settings.html` |
| SCR-017 Admin Users | Breadcrumb "Admin" | Click | SCR-016 Admin Dashboard | `wireframe-SCR-016-admin-dashboard.html` |
| SCR-018 Admin Audit | Breadcrumb "Admin" | Click | SCR-016 Admin Dashboard | `wireframe-SCR-016-admin-dashboard.html` |
| SCR-019 Admin Settings | Breadcrumb "Admin" | Click | SCR-016 Admin Dashboard | `wireframe-SCR-016-admin-dashboard.html` |

### 3.8 Task Prioritization (FL-008)

| Source Screen | Trigger Element | Action | Target Screen | Link Href |
|--------------|----------------|--------|---------------|-----------|
| SCR-012 AI Priority | Task item click | Click | SCR-007 Task Detail | `wireframe-SCR-007-task-detail.html` |

## 4. Persistent Navigation (Sidebar)

All authenticated screens (SCR-005 through SCR-015) share a sidebar with these links:

| Nav Item | Icon | Target Screen | Link Href |
|----------|------|---------------|-----------|
| Dashboard | grid | SCR-013 | `wireframe-SCR-013-dashboard.html` |
| Tasks | check-square | SCR-006 | `wireframe-SCR-006-task-list.html` |
| AI Input | sparkle | SCR-011 | `wireframe-SCR-011-ai-task-input.html` |
| AI Priority | trending-up | SCR-012 | `wireframe-SCR-012-ai-priority.html` |
| Reminders | bell | SCR-010 | `wireframe-SCR-010-upcoming-reminders.html` |
| Notifications | mail | SCR-015 | `wireframe-SCR-015-notification-history.html` |
| Profile | user | SCR-005 | `wireframe-SCR-005-user-profile.html` |

## 5. Admin Sidebar Navigation

Admin screens (SCR-016 through SCR-019) share an admin sidebar:

| Nav Item | Icon | Target Screen | Link Href |
|----------|------|---------------|-----------|
| Dashboard | shield | SCR-016 | `wireframe-SCR-016-admin-dashboard.html` |
| Users | users | SCR-017 | `wireframe-SCR-017-admin-users.html` |
| Audit Log | scroll | SCR-018 | `wireframe-SCR-018-admin-audit-log.html` |
| Settings | settings | SCR-019 | `wireframe-SCR-019-admin-settings.html` |

## 6. Header Utility Navigation

Present on all authenticated screens:

| Element | Action | Target |
|---------|--------|--------|
| Notification bell icon | Click | SCR-015 (`wireframe-SCR-015-notification-history.html`) |
| AI shortcut button | Click | SCR-011 (`wireframe-SCR-011-ai-task-input.html`) |
| Avatar dropdown → Profile | Click | SCR-005 (`wireframe-SCR-005-user-profile.html`) |
| Avatar dropdown → Logout | Click | SCR-001 (`wireframe-SCR-001-login.html`) |

## 7. Breadcrumb Patterns

| Screen | Breadcrumb Path |
|--------|----------------|
| SCR-007 Task Detail | Dashboard > Tasks > {Task Title} |
| SCR-008 Task Form (New) | Dashboard > Tasks > New Task |
| SCR-008 Task Form (Edit) | Dashboard > Tasks > {Task Title} > Edit |
| SCR-009 Reminder Modal | (No breadcrumb — modal overlay) |
| SCR-017 Admin Users | Admin > User Management |
| SCR-018 Admin Audit | Admin > Audit Log |
| SCR-019 Admin Settings | Admin > System Settings |

## 8. Mobile Navigation Mapping

On mobile (< 768px), the sidebar collapses to a bottom navigation bar with 5 items:

| Position | Label | Icon | Target | Maps to Sidebar Item |
|----------|-------|------|--------|---------------------|
| 1 | Home | grid | SCR-013 | Dashboard |
| 2 | Tasks | check | SCR-006 | Tasks |
| 3 | AI | sparkle | SCR-011 | AI Input (elevated FAB) |
| 4 | Alerts | bell | SCR-010 | Reminders |
| 5 | Me | user | SCR-005 | Profile |

Secondary screens (SCR-012, SCR-014, SCR-015) accessible via header icons or profile menu.

## 9. Navigation State Indicators

| State | Visual Treatment |
|-------|-----------------|
| Active page | Sidebar: primary-100 bg + primary-600 text + 3px left border |
| Hover | Sidebar: neutral-50 bg |
| Focus | 2px focus ring (primary-400) |
| Disabled | Not applicable (all nav items always available for authorized users) |
| Badge count | Notification bell shows unread count (primary-500 dot) |
