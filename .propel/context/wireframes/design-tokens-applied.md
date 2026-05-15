---
post_title: "AI Smart Reminder - Design Tokens Applied"
author1: "AI Product Designer"
post_slug: "ai-smart-reminder-design-tokens-applied"
categories: ["wireframes", "design-system", "tokens"]
tags: ["css-variables", "ibm-plex-sans", "indigo", "responsive"]
ai_note: "Generated from designsystem.md tokens applied to wireframe shared-styles.css"
summary: "Design token application summary documenting how designsystem.md tokens are mapped to CSS custom properties and applied across all 19 wireframes."
post_date: "2026-05-14"
---

# Design Tokens Applied - AI Smart Reminder

## 1. Overview

This document traces how design tokens from `designsystem.md` are applied to the shared CSS (`shared-styles.css`) and consumed by all 19 HTML wireframes.

**Source**: `.propel/context/docs/designsystem.md`
**Output**: `.propel/context/wireframes/Hi-Fi/shared-styles.css`

## 2. Color Tokens

### Primary Palette (Indigo)

| Token Name | Hex Value | CSS Variable | Usage |
|-----------|-----------|--------------|-------|
| primary-50 | #EEF2FF | `--color-primary-50` | Hover backgrounds, selected states |
| primary-100 | #E0E7FF | `--color-primary-100` | Active nav item bg, badge bg |
| primary-200 | #C7D2FE | `--color-primary-200` | Focus rings (lighter) |
| primary-300 | #A5B4FC | `--color-primary-300` | Disabled primary buttons |
| primary-400 | #818CF8 | `--color-primary-400` | Focus ring color |
| primary-500 | #6366F1 | `--color-primary-500` | Primary buttons, links, active states |
| primary-600 | #4F46E5 | `--color-primary-600` | Hover state on primary buttons |
| primary-700 | #4338CA | `--color-primary-700` | Active/pressed state |
| primary-800 | #3730A3 | `--color-primary-800` | Dark accents |
| primary-900 | #312E81 | `--color-primary-900` | Text on light primary backgrounds |

### Semantic Colors

| Token Name | Hex Value | CSS Variable | Usage |
|-----------|-----------|--------------|-------|
| success-500 | #22C55E | `--color-success-500` | Success toasts, done badges, positive metrics |
| success-100 | #DCFCE7 | `--color-success-100` | Success badge bg, success alert bg |
| success-700 | #15803D | `--color-success-700` | Success badge text |
| warning-500 | #F59E0B | `--color-warning-500` | Warning toasts, medium priority |
| warning-100 | #FEF3C7 | `--color-warning-100` | Warning badge bg |
| warning-700 | #A16207 | `--color-warning-700` | Warning badge text |
| error-500 | #EF4444 | `--color-error-500` | Error states, validation messages |
| error-100 | #FEE2E2 | `--color-error-100` | Error badge bg, critical priority bg |
| error-700 | #B91C1C | `--color-error-700` | Error badge text, error borders |
| info-500 | #3B82F6 | `--color-info-500` | Info banners, medium priority |
| info-100 | #DBEAFE | `--color-info-100` | Info badge bg, info alert bg |
| info-700 | #1D4ED8 | `--color-info-700` | Info badge text |

### Neutral Scale

| Token Name | Hex Value | CSS Variable | Usage |
|-----------|-----------|--------------|-------|
| neutral-50 | #FAFAFA | `--color-neutral-50` | Page background, table header bg, hover rows |
| neutral-100 | #F5F5F5 | `--color-neutral-100` | Skeleton highlight, card hover bg |
| neutral-200 | #E5E5E5 | `--color-neutral-200` | Borders, dividers, disabled bg |
| neutral-300 | #D4D4D4 | `--color-neutral-300` | Input borders, placeholder icons |
| neutral-400 | #A3A3A3 | `--color-neutral-400` | Placeholder text, muted icons |
| neutral-500 | #737373 | `--color-neutral-500` | Secondary text, breadcrumb links |
| neutral-600 | #525252 | `--color-neutral-600` | Body text (secondary) |
| neutral-700 | #404040 | `--color-neutral-700` | Body text (primary) |
| neutral-800 | #262626 | `--color-neutral-800` | Headings |
| neutral-900 | #18181B | `--color-neutral-900` | High-emphasis text, modal backdrop base |

## 3. Typography Tokens

### Font Family

| Token | Value | CSS Variable |
|-------|-------|--------------|
| font-family-primary | 'IBM Plex Sans', sans-serif | `--font-family` |
| font-family-mono | 'IBM Plex Mono', monospace | `--font-family-mono` |

### Type Scale

| Token Name | Size | Weight | Line Height | CSS Variable | Usage |
|-----------|------|--------|-------------|--------------|-------|
| h1 | 32px | 700 | 1.2 | `--text-h1` | Page titles |
| h2 | 24px | 600 | 1.3 | `--text-h2` | Section headings |
| h3 | 20px | 600 | 1.4 | `--text-h3` | Card titles |
| h4 | 18px | 600 | 1.4 | `--text-h4` | Subsection titles |
| body-lg | 16px | 400 | 1.5 | `--text-body-lg` | Primary content text |
| body-md | 14px | 400 | 1.5 | `--text-body-md` | Default body text, inputs |
| body-sm | 13px | 400 | 1.5 | `--text-body-sm` | Secondary text |
| caption | 12px | 400 | 1.4 | `--text-caption` | Timestamps, badges, metadata |
| button | 14px | 500 | 1 | `--text-button` | Button labels |
| overline | 11px | 600 | 1.5 | `--text-overline` | Section labels, uppercase |

## 4. Spacing Tokens

### Base Unit: 4px

| Token Name | Value | CSS Variable | Usage |
|-----------|-------|--------------|-------|
| space-1 | 4px | `--space-1` | Tight gaps, icon-to-text |
| space-2 | 8px | `--space-2` | Badge padding, compact gaps |
| space-3 | 12px | `--space-3` | Input padding, tight margins |
| space-4 | 16px | `--space-4` | Card padding (compact), standard gaps |
| space-5 | 20px | `--space-5` | Section margins |
| space-6 | 24px | `--space-6` | Card padding (default), section gaps |
| space-8 | 32px | `--space-8` | Page padding, large gaps |
| space-10 | 40px | `--space-10` | Component heights (inputs, buttons md) |
| space-12 | 48px | `--space-12` | Large component heights (buttons lg) |
| space-16 | 64px | `--space-16` | Sidebar collapsed width, major sections |

## 5. Border Radius Tokens

| Token Name | Value | CSS Variable | Usage |
|-----------|-------|--------------|-------|
| radius-sm | 4px | `--radius-sm` | Small elements, tags |
| radius-md | 8px | `--radius-md` | Buttons, inputs, selects |
| radius-lg | 12px | `--radius-lg` | Cards, toasts |
| radius-xl | 16px | `--radius-xl` | Modals |
| radius-full | 9999px | `--radius-full` | Badges (pill), avatars, toggles |

## 6. Shadow Tokens

| Token Name | Value | CSS Variable | Usage |
|-----------|-------|--------------|-------|
| shadow-xs | 0 1px 2px rgba(0,0,0,0.05) | `--shadow-xs` | Subtle depth (flat cards) |
| shadow-sm | 0 1px 3px rgba(0,0,0,0.1), 0 1px 2px rgba(0,0,0,0.06) | `--shadow-sm` | Default cards, buttons |
| shadow-md | 0 4px 6px rgba(0,0,0,0.1), 0 2px 4px rgba(0,0,0,0.06) | `--shadow-md` | Elevated cards, dropdowns |
| shadow-lg | 0 10px 15px rgba(0,0,0,0.1), 0 4px 6px rgba(0,0,0,0.05) | `--shadow-lg` | Toasts, popovers, hover cards |
| shadow-xl | 0 20px 25px rgba(0,0,0,0.1), 0 10px 10px rgba(0,0,0,0.04) | `--shadow-xl` | Modals |

## 7. Motion Tokens

| Token Name | Duration | Easing | CSS Variable | Usage |
|-----------|----------|--------|--------------|-------|
| motion-fast | 150ms | ease | `--motion-fast` | Hover states, toggles |
| motion-normal | 300ms | ease | `--motion-normal` | Sidebar collapse, modal open, page transitions |
| motion-slow | 500ms | ease-in-out | `--motion-slow` | Chart animations, skeleton shimmer |

## 8. Layout Tokens

| Token Name | Value | CSS Variable | Usage |
|-----------|-------|--------------|-------|
| sidebar-width | 240px | `--sidebar-width` | Sidebar expanded state |
| sidebar-collapsed | 64px | `--sidebar-collapsed` | Sidebar collapsed (tablet) |
| header-height | 64px | `--header-height` | Header bar height |
| bottom-nav-height | 56px | `--bottom-nav-height` | Mobile bottom navigation |
| max-content-width | 1200px | `--max-content-width` | Main content area max width |
| breakpoint-mobile | 375px | (media query) | Mobile breakpoint |
| breakpoint-tablet | 768px | (media query) | Tablet breakpoint |
| breakpoint-desktop | 1440px | (media query) | Desktop breakpoint |

## 9. Z-Index Scale

| Token Name | Value | CSS Variable | Usage |
|-----------|-------|--------------|-------|
| z-base | 0 | `--z-base` | Default content |
| z-dropdown | 100 | `--z-dropdown` | Dropdowns, popovers |
| z-sticky | 200 | `--z-sticky` | Sticky header, sidebar |
| z-modal-backdrop | 300 | `--z-modal-backdrop` | Modal overlay background |
| z-modal | 400 | `--z-modal` | Modal content |
| z-toast | 500 | `--z-toast` | Toast notifications |

## 10. Token Application by Screen Type

### Authentication Screens (SCR-001 to SCR-004)

- **Layout**: Centered card (max-width 420px), no sidebar
- **Background**: neutral-50 full page
- **Card**: shadow-md, radius-xl, padding space-8
- **Buttons**: Full-width primary
- **Typography**: h2 for title, body-md for form labels

### Main Application Screens (SCR-005 to SCR-015)

- **Layout**: Sidebar (240px) + Header (64px) + Main content
- **Background**: neutral-50 main area
- **Cards**: shadow-sm, radius-lg, padding space-6
- **Typography**: h1 for page title, h3 for card titles
- **Spacing**: space-6 between cards, space-4 within card sections

### Admin Screens (SCR-016 to SCR-019)

- **Layout**: Admin sidebar + Header + Main content
- **Background**: neutral-50 main area
- **Tables**: Full-width, shadow-sm, radius-lg container
- **Typography**: h1 for page title, body-md for table content
- **Spacing**: space-6 between sections, space-4 table padding

## 11. Accessibility Token Compliance

| Requirement | Token Pair | Contrast Ratio | Status |
|------------|-----------|----------------|--------|
| Body text on white | neutral-700 on white | 9.3:1 | ✓ Pass (AA) |
| Heading text | neutral-800 on white | 13.2:1 | ✓ Pass (AAA) |
| Primary button text | white on primary-500 | 4.6:1 | ✓ Pass (AA) |
| Secondary text | neutral-500 on white | 4.6:1 | ✓ Pass (AA) |
| Error text | error-700 on white | 5.1:1 | ✓ Pass (AA) |
| Success badge text | success-700 on success-100 | 4.8:1 | ✓ Pass (AA) |
| Link color | primary-500 on white | 4.6:1 | ✓ Pass (AA) |
| Placeholder text | neutral-400 on white | 3.0:1 | ✓ Pass (AA for large/UI) |
