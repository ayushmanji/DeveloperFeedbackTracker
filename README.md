# 🧑‍💻 Developer Feedback Tracker API

A simple ASP.NET Core MVC web application that lets users track feedback about developers. This project simulates a basic review/feedback system using forms, model binding, validation, and a relational database with Entity Framework.

---

## 📋 Table of Contents

- 📌 About the Project
- 🧰 Tech Stack
- 🚀 Features
- 🛠 Getting Started
- 🖼 Screenshots
- 🧭 Project Journey
- 🐞 Challenges Faced
- 📈 Future Improvements
- 📜 License

---

## 📌 About the Project

This web app enables users to submit feedback related to developer performance. Each developer has a unique profile that stores their feedback entries. The goal was to understand the MVC flow, Entity Framework relationships, and project structuring in ASP.NET Core.

---

## 🧰 Tech Stack

| Technology        | Description                       |
|-------------------|-----------------------------------|
| ASP.NET Core MVC  | Web framework (C#)                |
| Entity Framework  | Object-relational mapping (ORM)   |
| SQL Server        | Backend database                  |
| Razor Pages       | View engine                       |
| Bootstrap         | UI styling (optional)             |
| Git + GitHub      | Version control + hosting         |

---

## 🚀 Features

- 🧑 Developer registration (name, email)
- 📝 Add feedback with title, message, tag
- 📋 View developer details with feedback history
- ❌ Delete developer (and all related feedback)
- ✅ Server-side validation for forms
- 🔗 Navigation between views


## 🛠 Getting Started

### 1. Clone the Repository
```
git clone https://github.com/ayushmanji/DeveloperFeedbackTracker.git
cd DeveloperFeedbackTracker
```
### 2. Configure the Database
- Edit appsettings.json with your SQL Server connection string.
- Run migrations (if using EF migrations) or:
```
dotnet ef database update
```

### 3. Run the Application
```
dotnet run
```
Open browser at: https://localhost:7164

🖼 Screenshots

### 🔍 Developer List
![Developer List](screenshots/Screenshot%202025-12-14%20195207.png)

### ➕ Add Feedback Form
![Add Feedback](screenshots/Screenshot%202025-12-14%20195306.png)

### 👤 Developer Details with Feedback
![Developer Details](screenshots/Screenshot%202025-12-14%20195334.png)

📌 Place your screenshots inside a screenshots folder.

🧭 Project Journey
This project was part of my preparation for backend developer interviews. I wanted to reinforce my understanding of:

- MVC flow in ASP.NET Core
- Database relationships using Entity Framework
- Razor page form handling and model binding
- Error handling and validation
- Clean code structure and reusable components

I started with creating the developer model and then expanded into feedback handling with a foreign key relationship. Each feature helped me build confidence in backend structure and UI integration.

🐞 Challenges Faced
- Razor form model binding not passing DeveloperId → solved by using hidden field
- 404 on DeleteConfirmed → fixed by ensuring [HttpPost, ActionName("Delete")] matches view form
- Validation not displaying → resolved with asp-validation-for and _ValidationScriptsPartial.cshtml
- Entity not found issues → added null checks and used .Include() for EF navigation properties

These helped me learn how errors flow through MVC layers and how to debug effectively.

📈 Future Improvements
- Add login/authentication for users
- Convert into full API for React or Angular frontend
- Tag filtering or feedback search feature
- Improve UI/UX with Tailwind or Bootstrap 5
- Add pagination for large feedback lists

📜 License
This project is open source under the MIT License.

Made with ❤️ by Ayushman Sharma
---

✅ You can now:
- Add your real screenshots in `screenshots/` folder.
- Push to GitHub:
```
git add README.md screenshots/
git commit -m "Add complete project README with journey and screenshots"
git push
```
