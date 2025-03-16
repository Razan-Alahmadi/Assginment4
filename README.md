
# E-commerce Full-Stack Application - Documentation  

## Overview  
This project is a full-stack **E-commerce application** integrating **Angular with NgRx** for state management and a **.NET Core microservices-based backend**. It includes a **Product Service** for managing the product catalog and an **Order Service** for handling customer orders.  

The frontend follows **modern Angular architecture**, using **NgRx Store, Actions, Reducers, Selectors, and Effects** to manage application state efficiently. The backend uses **.NET Core with Entity Framework Core (EF Core) and MySQL**, exposing **REST APIs** for communication.  

---

## Project Structure  

### Frontend (Angular + NgRx)  
**Technologies Used:** Angular, TypeScript, NgRx (Store, Effects, Selectors)  

- **State Management**: Implemented using **NgRx Store** for managing products and orders.  
- **NgRx Effects**: Handles API calls asynchronously, updating the store after fetching data.  
- **Selectors**: Used to derive specific data from the NgRx Store efficiently.  
- **Components**:  
  - `ProductListComponent` → Displays the product catalog using NgRx selectors.  
  - `OrderComponent` → Handles order placement.  
- **Services**:  
  - `ProductService` → Manages communication with the Product API.  
  - `OrderService` → Manages communication with the Order API.  
- **Error Handling & Loading Indicators**: Used to show feedback when data is loading or an error occurs.  

---

### Backend (.NET Core Microservices)  
**Technologies Used:** .NET Core, C#, Entity Framework Core (EF Core), MySQL, REST API  

#### 1️⃣ Product Microservice  
- Developed a **Product API** to perform **CRUD (Create, Read, Update, Delete) operations**.  
- Used **Entity Framework Core (EF Core)** for **database interactions**.  
- Exposed **REST API endpoints** for managing products.  

#### 2️⃣ Order Microservice  
- Implemented an **Order API** for **placing, updating, and retrieving orders**.  
- Stored order information in a **MySQL database**.  
- Used **EF Core** for efficient data handling.  

#### 3️⃣ Database Integration  
- Used **MySQL** as the relational database for storing products and orders.  
- Configured **migrations** using EF Core to manage schema changes.  

---

## Implementation Details  

### 🔹 Angular + NgRx Integration  
✅ **NgRx Store**: Created a **store** for managing products and orders.  
✅ **Actions & Reducers**: Defined **actions** for fetching, adding, and deleting products/orders, with **reducers** handling state updates.  
✅ **NgRx Effects**: Implemented effects to **fetch data asynchronously** from the .NET Core backend.  
✅ **Selectors**: Used selectors to retrieve data from the store and optimize UI updates.  

### 🔹 Backend Microservices in .NET Core  
✅ **Created two microservices**: `ProductService` and `OrderService`.  
✅ **Implemented REST APIs** for managing products and orders.  
✅ **Connected to a MySQL database** using EF Core.  
✅ **Exposed API endpoints** for frontend communication.  
✅ **Tested API functionality** using **Swagger**.  

### 🔹 Frontend-Backend Communication  
✅ Used **HttpClient** in Angular services to call the microservices APIs.  
✅ Implemented **NgRx Effects** to handle API requests efficiently.  
✅ Handled **loading and error states** in UI.  

---

## How to Run the Project  

### 1️⃣ Clone the Repository  
```bash
git clone https://github.com/Razan-Alahmadi/Assginment4.git
```

### 2️⃣ Set Up the Backend (.NET Core Microservices)  

#### Step 1: Configure the Database  
- Ensure **MySQL** is running and update the **connection string** in `appsettings.json`.  
  ```  

#### Step 2: Apply Database Migrations  
```bash
cd ProductService
dotnet ef database update  # Run for Product Service
cd ../OrderService
dotnet ef database update  # Run for Order Service
```  

#### Step 3: Run the Microservices  
```bash
cd ProductService
dotnet run  # Runs the Product Service
cd ../OrderService
dotnet run  # Runs the Order Service
```  

- The **Product API** will be available at `http://localhost:5296/api/products`.  
- The **Order API** will be available at `http://localhost:5013/api/orders`.  

---

### 3️⃣ Set Up the Frontend (Angular + NgRx)  

#### Step 1: Install Dependencies  
```bash
cd frontend
npm install
```  

#### Step 2: Start the Angular App  
```bash
ng serve
```  
- The Angular app will be available at `http://localhost:4200/`.  

---

## Testing the Application  

### ✔ API Testing (Postman or Swagger)  
- **Test Product API**: `GET http://localhost:5296/api/products`  
- **Test Order API**: `POST http://localhost:5013/api/orders`  

---
