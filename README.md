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

---
### 🔹 Build with Kubernetes and Load Minicube

```bash
docker build -t ordersystem-api:vX -f .\Order.Api\Dockerfile
minikube image load ordersysetm-api:vX
```

---
### 🔹 Deploy Minicube

```bash
kubectl apply -f .\k8s\postgres.yaml
kubectl apply -f .\k8s\kafka.yaml
kubectl apply -f .\k8s\migration-job.yaml
kubectl apply -f .\k8s\orders-api-deployment.yaml
kubectl apply -f .\k8s\orders-workers-deployment.yaml
kubectl apply -f .\k8s\prometheus.yaml
kubectl apply -f .\k8s\grafana.yaml
```

---
### 🔹 Basic Observability 

```bash
kubectl get pods -n order-system
kubectl logs <pod-name> -n order-system 
```

---


## 🔁 Resilience with Polly

The application uses Polly to handle failures:

Retry policies
Circuit breaker
Timeout strategies

Ensuring the system remains stable under transient failures.

---

## 📈 Features
Event-driven architecture
Asynchronous processing
Fault tolerance
Scalable design
Clean and maintainable code

---
## 🧠 Learnings

This project explores:

Designing distributed systems
Handling eventual consistency
Implementing resilience patterns
Working with messaging systems

---

## 📂 Project Structure
```bash
src/
 ├── API
 ├── Application
 ├── Domain
 ├── Infrastructure
```
---
## 🚀 Future Improvements
Add observability (Datadog)
Add authentication & authorization
Improve monitoring and logging

---
## 👩‍💻 Author

Senior Backend .NET Developer
Focused on scalable, resilient, and high-performance systems

