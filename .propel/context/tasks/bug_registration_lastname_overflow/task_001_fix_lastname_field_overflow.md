# Bug Fix Task - Registration Last Name Field Overflow

## Bug Report Reference

- Bug ID: N/A (wireframe visual review)
- Source: SCR-002 Registration wireframe screenshot + `.propel/context/wireframes/Hi-Fi-v2/wireframe-SCR-002-registration.html`

## Bug Summary

### Issue Classification

- **Priority**: Medium
- **Severity**: UI layout overflow — cosmetic, no data loss
- **Affected Version**: Hi-Fi-v2 wireframes (current)
- **Environment**: All browsers rendering `wireframe-SCR-002-registration.html`

### Steps to Reproduce

1. Open `wireframe-SCR-002-registration.html` in any browser.
2. Observe the "First name / Last name" two-column grid row.
3. **Expected**: Both input fields are contained within the auth-card boundary (440 px max-width).
4. **Actual**: The "Last name" input extends past the right edge of the card.

**Error Output**:

```text
No runtime error — visual overflow of the Last Name <input> beyond the .auth-card right edge.
```

### Root Cause Analysis

- **File**: `.propel/context/wireframes/Hi-Fi-v2/shared-styles.css:591`
- **Component**: `.form-input` CSS rule
- **Function**: N/A (CSS styling)
- **Cause**: The `.form-input` class does not declare `width: 100%`. HTML `<input>` elements have a browser-intrinsic width (~150–200 px) and do not automatically stretch to fill flex/grid parents the way block elements do. Inside the narrow 2-column grid within the 440 px auth-card, the intrinsic width causes the right-column input to overflow.

### Impact Assessment

- **Affected Features**: All wireframe screens that place `.form-input` inside a multi-column grid (SCR-002, SCR-005, SCR-008, SCR-009, SCR-014)
- **User Impact**: Layout appears broken; right-side form fields clip outside card/container
- **Data Integrity Risk**: No
- **Security Implications**: None

## Fix Overview

Add `width: 100%` to the `.form-input` rule in `shared-styles.css` so inputs always fill their parent container. Apply the same fix to `.form-textarea` and `.form-select` for consistency.

## Fix Dependencies

- None — CSS-only change.

## Impacted Components

### Frontend (CSS)

- `.propel/context/wireframes/Hi-Fi-v2/shared-styles.css` — MODIFY `.form-input`, `.form-textarea`, `.form-select` rules

## Expected Changes

| Action | File Path | Description |
|--------|-----------|-------------|
| MODIFY | `.propel/context/wireframes/Hi-Fi-v2/shared-styles.css` | Add `width: 100%` to `.form-input` (line ~591), `.form-textarea` (line ~615), `.form-select` (line ~637) |

## Implementation Plan

1. Open `shared-styles.css`.
2. Locate the `.form-input` rule (line 591).
3. Add `width: 100%;` as the first property inside the rule.
4. Locate `.form-textarea` (line 615) and `.form-select` (line 637) — add `width: 100%;` to each for consistency.
5. Visual-verify SCR-002 and any other multi-column form screens.

## Regression Prevention Strategy

- [ ] Visual check SCR-002 — both name fields contained within card
- [ ] Visual check SCR-005 (User Profile) — 2-column personal info grid
- [ ] Visual check SCR-008 (Task Form) — 2-column priority/category grid
- [ ] Visual check SCR-009 (Reminder Modal) — date/time grid
- [ ] Visual check SCR-014 (Notification Settings) — quiet-hours time inputs

## Rollback Procedure

1. Remove the `width: 100%;` line from `.form-input`, `.form-textarea`, and `.form-select`.
2. Refresh affected screens and verify original rendering returns.

## External References

- [MDN — Styling form controls](https://developer.mozilla.org/en-US/docs/Learn/Forms/Styling_web_forms)
- CSS spec: replaced elements in flex/grid do not stretch by default without explicit `width`.

## Build Commands

- N/A — static HTML/CSS wireframes. Open `.html` files directly in browser.

## Implementation Validation Strategy

- [ ] Bug no longer reproducible: Last Name field contained within card
- [ ] All other form screens render correctly with `width: 100%`
- [ ] No horizontal scrollbar appears on any auth or form screen

## Implementation Checklist

- [x] Add `width: 100%` to `.form-input`
- [x] Add `width: 100%` to `.form-textarea`
- [x] Add `width: 100%` to `.form-select`
- [x] Visual verify SCR-002, SCR-005, SCR-008, SCR-009, SCR-014
