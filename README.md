# 📁 File Organizer

A clean, open source file organizer for Windows. Automatically sorts your files into categorized folders with a Bloxstrap-inspired UI.

## ✨ Features

- **Auto Organize** — sorts files into Images, Videos, Music, Documents, Programs, Archives, Code, and Other
- **Custom Rules** — create your own rules based on filename, extension, file size, or date
- **Preview Mode** — see what will happen before moving anything
- **Undo** — instantly restore all moved files with one click
- **Password Protection** — secure the app with a password or 4-digit PIN
- **Startup Option** — launch automatically with Windows
- **Activity Log** — see exactly what was moved in real time
- **Progress Bar** — visual feedback while organizing

## 🚀 Download

Download the latest `FileOrganizer.exe` from the releases section.

## 🖥️ Requirements

- Windows 10 or later
- No .NET installation required (self-contained)

## 📖 How to Use

1. Launch `FileOrganizer.exe`
2. Set up your password or PIN on first launch
3. Go to **Organizer** tab
4. Click **Browse** and select a folder to organize
5. Optionally toggle **Preview** to see what will move
6. Click **Organize Files**
7. Use **Undo** if you want to revert

## ✏️ Custom Rules

Go to the **Custom** tab to add rules:

| Type | Example Value | What it does |
|------|--------------|--------------|
| Contains | `invoice` | Moves files with "invoice" in the name |
| Extension | `.psd` | Moves files with that extension |
| Size | `500` | Moves files over 500 MB |
| Date | `30` | Moves files older than 30 days |

## 🔒 Security

- Passwords and PINs are hashed with SHA-256 before storing
- Credentials are stored locally only, never sent anywhere
- 5 attempt lockout on wrong password/PIN

## 📄 License

MIT License — see [LICENSE](LICENSE) for details.