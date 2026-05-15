---
post_title: "AI Smart Reminder - Component Inventory"
author1: "AI Product Designer"
post_slug: "ai-smart-reminder-component-inventory"
categories: ["wireframes", "components", "design-system"]
tags: ["angular", "ui-components", "responsive", "accessibility"]
ai_note: "Generated from figma_spec.md Section 10 and designsystem.md token definitions"
summary: "Complete component inventory documenting all UI components used across 19 wireframes with variants, states, design tokens, and accessibility requirements."
post_date: "2026-05-14"
---

# Component Inventory - AI Smart Reminder

## 1. Overview

This document catalogs all UI components used across the AI Smart Reminder wireframes. Each component maps to Angular Material or custom components in the Angular 18+ implementation.

**Design System Reference**: See [Design Tokens Applied](./design-tokens-applied.md) for token values.

## 2. Component Catalog

### 2.1 Button

| Property | Value |
|----------|-------|
| Variants | Primary, Secondary, Outline, Ghost |
| Sizes | Small (32px), Medium (40px), Large (48px) |
| States | Default, Hover, Focus, Active, Disabled, Loading |
| Border Radius | 8px |
| Font | IBM Plex Sans 500 |
| Min Width | 80px |
| Icon Support | Leading icon, trailing icon, icon-only |

**Usage by Screen**:
- SCR-001: Primary (Login), Outline (Register link)
- SCR-006: Primary (New Task), Secondary (Filter actions)
- SCR-008: Primary (Save), Ghost (Cancel)
- SCR-009: Primary (Save Reminder), Ghost (Cancel)
- SCR-011: Primary (Parse), Outline (Confirm), Ghost (Reject)
- SCR-013: Primary (Quick actions)
- SCR-016–019: Primary (Admin actions), Secondary (Bulk operations)

**Accessibility**:
- `role="button"` for non-button elements
- `aria-disabled="true"` when disabled (preserve focus)
- `aria-busy="true"` with spinner during loading state
- Minimum touch target: 44×44px

---

### 2.2 TextField

| Property | Value |
|----------|-------|
| Variants | Default, With prefix/suffix icon, With helper text |
| Sizes | Medium (40px height), Large (48px height) |
| States | Default, Focus, Error, Disabled, Read-only |
| Border | 1px solid neutral-300; Focus: 2px solid primary-500 |
| Border Radius | 8px |
| Label | Above field, 14px 500 weight |
| Error Text | Below field, 12px, error-500 color |

**Usage by Screen**:
- SCR-001: Email, Password (with visibility toggle)
- SCR-002: Name, Email, Password
- SCR-003: Email
- SCR-004: New Password, Confirm Password
- SCR-005: Display Name, Email (read-only)
- SCR-008: Task Title, Description
- SCR-017: Search users
- SCR-018: Search audit log

**Accessibility**:
- `aria-required="true"` for required fields
- `aria-invalid="true"` + `aria-describedby` for error state
- Visible focus ring (2px offset)
- Associated `<label>` element

---

### 2.3 TextArea

| Property | Value |
|----------|-------|
| Min Height | 120px |
| Max Height | 300px (auto-expand) |
| Resize | Vertical only |
| Character Count | Optional, bottom-right |
| States | Default, Focus, Error, Disabled |

**Usage by Screen**:
- SCR-008: Task description/notes
- SCR-011: Natural language input (primary input)

---

### 2.4 Card

| Property | Value |
|----------|-------|
| Variants | Default, Interactive (clickable), Elevated, Flat |
| Padding | 16px (compact), 24px (default) |
| Border Radius | 12px |
| Shadow | shadow-sm (flat), shadow-md (elevated), shadow-lg (hover on interactive) |
| Border | 1px solid neutral-200 (flat variant) |

**Usage by Screen**:
- SCR-006: Task list items (interactive)
- SCR-007: Task detail card (elevated)
- SCR-011: AI parsed result card (elevated with highlight)
- SCR-012: Priority-ranked task cards (interactive)
- SCR-013: Metric cards (flat), AI insight cards (elevated)
- SCR-016: Admin metric cards (flat)

**Accessibility**:
- Interactive cards: `role="article"` or `role="link"` with keyboard activation
- Focus ring on interactive variants
- Card content has proper heading hierarchy

---

### 2.5 Badge

| Property | Value |
|----------|-------|
| Variants | Priority (Critical/High/Medium/Low), Status (Active/Done/Pending/Overdue/Snoozed), Channel (Email/SMS/Push) |
| Size | 20px height, padding 4px 8px |
| Border Radius | 9999px (pill) |
| Font | 12px 500 weight |

**Color Mapping**:
| Badge Type | Background | Text Color |
|-----------|------------|------------|
| Critical | error-100 | error-700 |
| High | warning-100 | warning-700 |
| Medium | info-100 | info-700 |
| Low | neutral-200 | neutral-600 |
| Done | success-100 | success-700 |
| Active | primary-100 | primary-700 |
| Overdue | error-100 | error-700 |

**Usage by Screen**:
- SCR-006: Priority + status badges on task cards
- SCR-007: Priority badge, reminder status badges
- SCR-010: Reminder type badges
- SCR-012: AI priority score badges
- SCR-015: Delivery status badges (sent/failed/pending)
- SCR-017: User status badges (active/suspended/pending)

---

### 2.6 Toast / Notification

| Property | Value |
|----------|-------|
| Variants | Success, Error, Warning, Info |
| Position | Top-right (desktop), Top-center (mobile) |
| Duration | 5000ms (auto-dismiss), persistent for errors |
| Width | 360px max |
| Border Radius | 12px |
| Shadow | shadow-lg |
| Animation | Slide in from right, fade out |

**Triggers**:
- Task created/updated/deleted → Success
- Reminder set/updated → Success
- AI parse error → Error
- Network failure → Error (persistent)
- Session expiring → Warning

**Accessibility**:
- `role="alert"` for errors, `role="status"` for success/info
- `aria-live="assertive"` for errors, `aria-live="polite"` for others
- Close button with `aria-label="Dismiss notification"`

---

### 2.7 Modal / Dialog

| Property | Value |
|----------|-------|
| Width | 480px (small), 640px (medium), 800px (large) |
| Border Radius | 16px |
| Backdrop | neutral-900 at 50% opacity |
| Shadow | shadow-xl |
| Padding | 24px |
| Animation | Scale up (0.95→1) + fade in, 300ms ease |

**Usage by Screen**:
- SCR-009: Reminder configuration (medium width)
- SCR-006: Delete confirmation (small width)
- SCR-014: Disable all channels warning (small width)
- Any screen: Session timeout re-auth (small width)

**Accessibility**:
- Focus trap within modal
- `role="dialog"` with `aria-modal="true"`
- `aria-labelledby` pointing to modal title
- Escape key closes modal
- Focus returns to trigger element on close

---

### 2.8 Table

| Property | Value |
|----------|-------|
| Header | Sticky, neutral-50 background, 14px 600 weight |
| Row Height | 48px minimum |
| Hover | neutral-50 background |
| Border | Bottom border between rows (neutral-200) |
| Responsive | Horizontal scroll on mobile; priority columns shown |

**Usage by Screen**:
- SCR-017: User management table (name, email, status, role, actions)
- SCR-018: Audit log table (timestamp, user, action, resource, details)
- SCR-019: Settings table (key, value, description, modified)

**Accessibility**:
- Proper `<thead>`, `<tbody>`, `<th scope="col">` structure
- `aria-sort` on sortable columns
- Row actions accessible via keyboard

---

### 2.9 Sidebar Navigation

| Property | Value |
|----------|-------|
| Width | 240px (expanded), 64px (collapsed) |
| Background | White |
| Border | Right border 1px neutral-200 |
| Item Height | 44px |
| Active Indicator | Primary-100 background, Primary-600 text, left border 3px primary-500 |
| Hover | Neutral-50 background |
| Transition | Width change 300ms ease |
| Sections | User nav (6 items), Admin nav (4 items, conditional) |

**Nav Items (User)**:
1. Dashboard (SCR-013) — grid icon
2. Tasks (SCR-006) — check-square icon
3. AI Input (SCR-011) — sparkle icon
4. AI Priority (SCR-012) — trending-up icon
5. Reminders (SCR-010) — bell icon
6. Notifications (SCR-015) — mail icon
7. Profile (SCR-005) — user icon (bottom-aligned)

**Nav Items (Admin)**:
1. Admin Dashboard (SCR-016) — shield icon
2. Users (SCR-017) — users icon
3. Audit Log (SCR-018) — scroll icon
4. Settings (SCR-019) — settings icon

**Accessibility**:
- `<nav aria-label="Main navigation">`
- `aria-current="page"` on active item
- `aria-expanded` on collapse/expand toggle
- Keyboard: Arrow keys for navigation within

---

### 2.10 Bottom Navigation (Mobile)

| Property | Value |
|----------|-------|
| Height | 56px + safe area |
| Items | 5 max |
| Active Indicator | Primary-500 icon + label color |
| Background | White with top shadow |

**Mobile Nav Items**:
1. Dashboard (SCR-013) — grid icon
2. Tasks (SCR-006) — check icon
3. AI (SCR-011) — sparkle icon (centered, elevated)
4. Reminders (SCR-010) — bell icon
5. Profile (SCR-005) — user icon

---

### 2.11 SearchField

| Property | Value |
|----------|-------|
| Variant | TextField with leading search icon |
| Debounce | 300ms |
| Clear Button | Visible when field has value |
| Placeholder | Context-specific (e.g., "Search tasks...") |

**Usage by Screen**:
- SCR-006: Search tasks by title/content
- SCR-017: Search users by name/email
- SCR-018: Search audit events

---

### 2.12 Select / Dropdown

| Property | Value |
|----------|-------|
| Height | 40px |
| Border Radius | 8px |
| Dropdown Shadow | shadow-md |
| Max Height | 240px (scrollable) |
| States | Default, Open, Disabled |
| Multi-select | Checkbox items variant |

**Usage by Screen**:
- SCR-006: Filter by priority, status, date range, category
- SCR-008: Priority select, category select
- SCR-009: Recurrence pattern, notification channel
- SCR-018: Filter by action type, user, date range

---

### 2.13 DatePicker / TimePicker

| Property | Value |
|----------|-------|
| Format | Date: YYYY-MM-DD display; Time: HH:MM (24h or 12h per locale) |
| Calendar | Monthly grid with today highlight |
| Past Date Validation | Warning for reminders; block for new tasks |
| Border Radius | 8px (input), 12px (calendar popup) |

**Usage by Screen**:
- SCR-008: Task due date
- SCR-009: Reminder date + time
- SCR-005: Quiet hours start/end time
- SCR-014: Quiet hours configuration

---

### 2.14 Toggle / Switch

| Property | Value |
|----------|-------|
| Size | 20×36px (track), 16×16px (thumb) |
| Colors | Off: neutral-300; On: primary-500 |
| Transition | 150ms ease |
| Label | Right-aligned text |

**Usage by Screen**:
- SCR-005: Enable email/SMS/push notifications
- SCR-009: Recurring reminder toggle
- SCR-014: Channel enable/disable toggles
- SCR-019: System feature toggles (admin)

**Accessibility**:
- `role="switch"` with `aria-checked`
- Associated label via `id`/`for`

---

### 2.15 Skeleton Loader

| Property | Value |
|----------|-------|
| Variants | Text (single line), Card, Table row, Chart |
| Animation | Shimmer (left-to-right gradient pulse) |
| Duration | 1.5s loop |
| Color | Neutral-200 base, neutral-100 highlight |

**Usage by Screen**:
- SCR-006: Task list loading state
- SCR-011: AI parsing in progress
- SCR-012: AI priority calculation
- SCR-013: Dashboard metrics loading

---

### 2.16 Pagination

| Property | Value |
|----------|-------|
| Variant | Numbered pages with prev/next arrows |
| Page Size Options | 10, 25, 50 |
| Active Page | Primary-500 background, white text |
| Disabled | Neutral-300 text for unavailable |

**Usage by Screen**:
- SCR-006: Task list pagination
- SCR-017: User management table
- SCR-018: Audit log table

---

### 2.17 Chart

| Property | Value |
|----------|-------|
| Types | Line (completion trend), Bar (daily tasks), Donut (category distribution) |
| Colors | Primary palette (primary-400 to primary-700) |
| Responsive | Scale to container width |
| Animation | Draw-in on mount (500ms) |

**Usage by Screen**:
- SCR-013: Completion trend (line), daily tasks (bar), category breakdown (donut)
- SCR-016: System metrics (line charts)

---

### 2.18 Alert / Banner

| Property | Value |
|----------|-------|
| Variants | Info, Success, Warning, Error |
| Border Radius | 8px |
| Padding | 12px 16px |
| Icon | Left-aligned variant icon |
| Dismissible | Optional close button |

**Usage by Screen**:
- SCR-008: AI suggestion banner (info)
- SCR-011: AI parsing error (error), AI suggestion confidence (info)
- SCR-012: AI model disclaimer (info)
- SCR-019: System maintenance warning (warning)

---

### 2.19 Breadcrumb

| Property | Value |
|----------|-------|
| Separator | ">" (chevron icon) |
| Current Page | Bold, no link |
| Font | 14px, neutral-500 (links), neutral-900 (current) |

**Usage by Screen**:
- SCR-007: Dashboard > Tasks > Task Detail
- SCR-008: Dashboard > Tasks > New Task / Edit Task
- SCR-017: Admin > User Management
- SCR-018: Admin > Audit Log

---

### 2.20 Avatar

| Property | Value |
|----------|-------|
| Sizes | 24px (inline), 32px (nav), 48px (profile) |
| Shape | Circle (border-radius: 9999px) |
| Fallback | Initials on primary-100 background |
| Border | 2px white border in header |

**Usage by Screen**:
- Header: User avatar in utility nav
- SCR-005: Large avatar on profile page
- SCR-017: User avatars in admin table

## 3. Component State Matrix

| Component | Default | Hover | Focus | Active | Disabled | Loading | Error | Empty |
|-----------|---------|-------|-------|--------|----------|---------|-------|-------|
| Button | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | — | — |
| TextField | ✓ | ✓ | ✓ | — | ✓ | — | ✓ | — |
| Card | ✓ | ✓* | ✓* | ✓* | — | ✓ | ✓ | ✓ |
| Table | ✓ | ✓ | ✓ | — | — | ✓ | ✓ | ✓ |
| Badge | ✓ | — | — | — | — | — | — | — |
| Select | ✓ | ✓ | ✓ | ✓ | ✓ | — | ✓ | — |
| Toggle | ✓ | ✓ | ✓ | — | ✓ | — | — | — |
| Sidebar | ✓ | ✓ | ✓ | ✓ | — | — | — | — |

*Interactive variant only

## 4. Design Token Mapping

| Component | Typography Token | Color Token | Spacing Token | Radius Token | Shadow Token |
|-----------|-----------------|-------------|---------------|--------------|--------------|
| Button (Primary) | button-md (14/500) | bg: primary-500, text: white | px: 16px, py: 8px | radius-md (8px) | shadow-sm |
| TextField | body-md (14/400) | border: neutral-300, focus: primary-500 | px: 12px, py: 10px | radius-md (8px) | — |
| Card | — | bg: white, border: neutral-200 | p: 16–24px | radius-lg (12px) | shadow-sm to shadow-md |
| Badge | caption (12/500) | variant-specific (see 2.5) | px: 8px, py: 4px | radius-full (9999px) | — |
| Toast | body-sm (14/500) | variant-specific | p: 16px | radius-lg (12px) | shadow-lg |
| Modal | — | bg: white, backdrop: neutral-900/50 | p: 24px | radius-xl (16px) | shadow-xl |
| Sidebar | body-md (14/500) | bg: white, active: primary-100 | item-py: 10px, px: 16px | — | — |

## 5. Responsive Adaptations

| Component | Desktop (1440px) | Tablet (768px) | Mobile (375px) |
|-----------|------------------|----------------|----------------|
| Sidebar | 240px persistent | 64px collapsed (icons) | Hidden; bottom nav |
| Card Grid | 3-column | 2-column | 1-column stacked |
| Table | Full columns | Priority columns + scroll | Card list view |
| Modal | Centered 480-800px | Centered 90% width | Full-screen sheet |
| Search | Inline expanded | Collapsed icon → expand | Full-width below header |
| Filters | Inline row | Dropdown | Bottom drawer |
| Pagination | Full numbered | Compact (prev/next + current) | Infinite scroll |

## 6. UXR Traceability

| Component | UXR Requirement | Implementation Note |
|-----------|----------------|-------------------|
| Button (Loading) | UXR-6 (AI response < 3s, loading indicator) | Spinner + disabled during AI calls |
| TextArea (SCR-011) | UXR-3 (NLP input area) | Large, auto-expand, placeholder guidance |
| Card (AI Result) | UXR-8 (AI confidence display) | Highlighted card with score badge |
| Toggle (Channels) | UXR-12 (Per-channel control) | Individual toggles per notification channel |
| Badge (Priority) | UXR-14 (AI priority visible) | Color-coded priority badges with reasoning |
| Toast | UXR-17 (Success confirmation) | Auto-dismiss success, persistent errors |
| Skeleton | UXR-6 (Loading states) | Contextual skeletons matching content shape |
| Modal (Reminder) | UXR-10 (Quick reminder creation) | Minimal required fields, smart defaults |
| Chart | UXR-19 (Productivity trends) | Interactive tooltips, responsive sizing |
| Table (Audit) | UXR-22 (Admin audit trail) | Sortable, filterable, exportable |
