# 🌍 AITravelPlanner.API

**AITravelPlanner.API** is a backend service for an AI-based travel planner application. It provides flight search, booking, recommendation services, and integration with AI models to optimize user experience.

---

## 📌 Features
✅ Flight Search and Booking (via BiletBank API)  
✅ AI-based Travel Recommendations (via FastAPI)  
✅ User Authentication & Authorization (JWT)  
✅ Database Management (EF Core + PostgreSQL)  
✅ RESTful API with OpenAPI Documentation (Swagger)  
✅ CI/CD with GitHub Actions (To be added)  
✅ Unit Testing (xUnit, Moq)  
✅ RabbitMQ for Asynchronous Processing (Optional)  

---

## 🚀 Tech Stack
- **Backend:** .NET 8 (ASP.NET Core Web API)
- **AI Service:** Python (FastAPI)
- **Database:** PostgreSQL / SQL Server
- **ORM:** Entity Framework Core
- **Authentication:** JWT
- **Logging:** Serilog
- **Messaging Queue:** RabbitMQ (Optional)
- **Containerization:** Docker (To be added)
- **CI/CD:** GitHub Actions (To be added)

---

## 📂 Project Structure
```bash
AITravelPlanner/
 ├── AITravelPlanner.API/         # .NET Core Web API (Backend)
 ├── AITravelPlanner.AIService/   # Python FastAPI AI recommendation service
 ├── AITravelPlanner.Common/      # Shared models and helper functions
 ├── AITravelPlanner.Data/        # Database access layer
 ├── AITravelPlanner.Domain/      # Entity and DTO models
 ├── AITravelPlanner.Services/    # Business logic service layer
 ├── AITravelPlanner.Tests/       # Unit tests
 ├── AITravelPlanner.Frontend/    # React or Next.js (Optional)
```

---

## 🛠️ Setup & Installation
### 1️⃣ **Clone the Repository**
```bash
git clone https://github.com/yaprakyildirim/AITravelPlanner.API.git
cd AITravelPlanner.API
```

### 2️⃣ **Set Up Environment Variables**
Create an `.env` file in the root directory and add:
```env
DATABASE_URL= "Host=localhost;Database=ai_travel;Username=postgres;Password=yourpassword"
JWT_SECRET= "your_jwt_secret_key"
```

### 3️⃣ **Install Dependencies**
```bash
dotnet restore
dotnet build
```

### 4️⃣ **Database Migration**
```bash
dotnet ef database update
```

### 5️⃣ **Run the API**
```bash
dotnet run
```

API will be available at: `http://localhost:5000`

### 6️⃣ **Swagger UI (API Docs)**
After running the API, open your browser and go to:
```
http://localhost:5000/swagger/index.html
```

---

## 📌 Running Tests
```bash
dotnet test
```

---

## 🛠️ CI/CD Pipeline (To Be Added)
We will integrate GitHub Actions for:
- ✅ Automated Tests on Pull Requests
- ✅ Deployment to Cloud/Docker
- ✅ Code Quality Checks

---

## 📜 License
This project is licensed under the **MIT License**.

---

## 👨‍💻 Contributors
- **[Yaprak Yıldırım](https://github.com/yaprakyildirim)** - Maintainer

---

## ⭐ Support & Feedback
If you find this project useful, consider giving it a ⭐ on GitHub!

For issues & suggestions, open a new issue in the [GitHub Repository](https://github.com/yaprakyildirim/AITravelPlanner.API/issues).
