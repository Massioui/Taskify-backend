# Taskify

Taskify is a task management system designed to help you stay productive and manage your daily activities efficiently.

---

## 📦 Modules
- **Authentication and Authorization**
- **Task Management**
- **Profile Management**
- **Notification System**

---

## ✨ Features

### 🔐 Authentication and Authorization
- Sign up using email/password.
- Log in with account credentials or third-party providers (Google, Facebook, GitHub).
- Reset password if forgotten.
- Confirm account through a verification link.

### ✅ Task Management
- Create, update, delete, and view tasks with details (title, summary, description, priority, deadline, attachments).
- List, sort, filter, search, and paginate tasks.
- Share tasks with other users and manage permissions.
- Configure task notifications (receive reminders via email before deadlines).
- Manage custom statuses and priorities (system-defined ones are view-only).

### 👤 Profile Management
- Confirm account if not already confirmed.
- Update profile details.
- Change email or password (confirmation via email code).
- Delete account permanently.

### 🔔 Notification System
- Get notifications based on personal settings.
- Receive alerts via email or SMS for task updates and deadlines.

---

## 🛠️ Tech Stack
- **Backend:** .NET 9 (Web API, EF Core, OpenAPI/Swagger)
- **Frontend:** Angular 18 with TailwindCSS
- **Database:** SQL Server (or PostgreSQL optional)
- **Authentication:** Identity core supporting external login, JWT
- **Notifications:** Email + SMS integration
- **Tooling:** ESLint, Prettier, Husky, GitHub Actions (CI/CD)

---

## 🚀 Getting Started

### Prerequisites
Make sure you have the following installed:
- [Node.js](https://nodejs.org/) (v20+)
- [Angular CLI](https://angular.dev/) (v18+)
- [.NET SDK](https://dotnet.microsoft.com/) (v9+)
- [SQL Server](https://www.microsoft.com/sql-server)

### Clone the Repository
```bash
git clone https://github.com/your-username/taskify.git
cd taskify
```

## 🚀 Getting Started
_Work in progress..._

---

## 📜 License
```text
MIT License © 2025 Taskify

Copyright (c) 2025 Bouchaib MASSIOUI

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```