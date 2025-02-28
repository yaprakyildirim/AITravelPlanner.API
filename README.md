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



## 👨‍💻 Contributors
- **[Yaprak Yıldırım](https://github.com/yaprakyildirim)** - Maintainer

---

## ⭐ Support & Feedback
If you find this project useful, consider giving it a ⭐ on GitHub!

For issues & suggestions, open a new issue in the [GitHub Repository](https://github.com/yaprakyildirim/AITravelPlanner.API/issues).
