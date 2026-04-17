# 🚀 Tradind System - Order Generator & Order Accumulator

This project implements a simplified trading System

The solution is composed of two main applications

- **Order Generator Web** → Web application that allows users to create and send orders
- **Order Generator API** → Backend Service that receives FIX messages and calculates
- **REST APIs**

## 📌 Overview

This project demonstrates the implementation of a backend system using:

- **.NET 8 / C#**
- **QuickFix 4.4** 
- **REST APIs**
- **MVC**

The system simulates order processing using oder Accumulator.

---

## 🧱 Architecture

The solution follows a layered architecture:

- **Web** → UIA Layer (asp.net mvc), sends orders via FIX
- **Application Layer** → Business logic, Interfaces
- **Domain Layer** → Core entities and rules
- **Infrastructure Layer** → FIX Integration, Resository implementation (in-memory)

---

## 🔄 Flow

1. Users submits order (UI)
2. Order Generator sends FIX message (NewOrderSigle)
3. Order Accumulator receives message
4. Message is parsed via MessageCracker t
5. Order is processed and stored 

---

## ⚙️ Tech Stack

- .NET 8
- ASP.NET MVC
- Quickfix 4.4 
- Clean Architecture principles 
- In-memory data storage 

---

## 🛠️ Running the Project

### 🔹 Prerequisites

- Docker & Docker Compose
- .NET SDK 8

---

### 🔹 Run Web UI

```bash
dotnet run --project OrderGenerator.Web
```
### 🔹 Run OrderAccumulator 

```bash
dotnet run --project OrderGenerator
```

## 📂 Project Structure
```bash
src/
 ├── API
 ├── Application
 ├── Domain
 ├── Infrastructure
```

## 👩‍💻 Author

Senior Backend .NET Developer
https://github.com/chrishiroshe/flowaorderacummulator


