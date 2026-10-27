# Library Management System

A Windows Forms application for library operations, written in C# on .NET Framework 4.8.

Coursework project built to practise multi-form navigation, data binding, and file-based persistence without a database server.

## Features

Twelve functional forms, covering the circulation workflow end to end:

| Area | Form | What it handles |
| --- | --- | --- |
| Catalogue | `FrmBookCategory` | Book categories — add, edit, delete |
| Catalogue | `FrmBookIn` | Stock intake for new titles |
| Catalogue | `FrmBookList` | Searchable book listing |
| Catalogue | `FrmBookCheck` | Inventory check against the catalogue |
| Circulation | `FrmBorrowRegister` | Borrow registration with reader and due date |
| Circulation | `FrmReturnBook` | Returns, with overdue calculation |
| Circulation | `FrmOverdue` | Overdue list and handling |
| Readers | `FrmReaderFile` | Reader records |
| Readers | `FrmReaderLoss` | Report a lost card, freeze the account |
| Administration | `FrmUserManage` | Operator accounts and permissions |
| Administration | `FrmChangePwd` | Password change with confirmation |
| Shell | `FrmMain` | Navigation shell, menu tree, status |

## Design notes

- **Persistence** — flat files in a local data directory rather than a database. Keeps the project runnable on any machine without setup, which mattered for coursework submission.
- **Navigation** — a single `FrmMain` shell hosts a menu tree; child forms open as modal dialogs and refresh the parent on close. No MDI, deliberately, to keep state ownership obvious.
- **Overdue logic** — computed from the borrow record's due date on read rather than stored as a flag, so the value can never drift out of sync.
- **Input validation** — every form validates before writing. Range checks on numeric fields, non-empty checks on keys, and duplicate-key detection on category names.

## Stack

- C# / .NET Framework 4.8
- Windows Forms
- Visual Studio 2022

## Build and run

```
msbuild WindowsFormsLibrarySystem.csproj
```

Or open the `.csproj` in Visual Studio 2022 and press F5. No database or external service required.

## Notes

Source comments are in Chinese — this was coursework, and the comments record the reasoning behind each decision as I worked through it.
