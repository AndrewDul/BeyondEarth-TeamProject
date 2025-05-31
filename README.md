# BeyondEarth – Order Management System

## 📦 Project Overview

This project is part of a larger e-commerce prototype system developed by a team of four students as part of the **CTEC2714 Software Engineering Team Project** at **De Montfort University**.

**BeyondEarth** offers a futuristic travel booking platform simulating Mars, Moon, and deep-sea experiences. The system follows a three-tier architecture and is developed using **C#**, **ASP.NET Web Forms**, and **SQL Server**. Each team member was responsible for a dedicated component.

This repository contains the implementation of the **Order Management System**, developed by **Andrzej Dul**.

---

## 👨‍💻 Developer Responsibility

**Component**: Order Management  
**Developer**: Andrzej Dul  

**Responsibilities**:
- `clsOrder` class (business logic)
- `clsOrderCollection` and integration with SQL
- Web Forms: `OrderList.aspx`, `OrderDataEntry.aspx`, `OrderStatistics.aspx`, `OrderConfirmDelete.aspx`, `TeamMainMenu.aspx`
- Styling with Bootstrap and custom CSS
- Full implementation of:
  - `Find()`, `Validate()`, `Add()`, `Update()`, `Delete()` methods
  - Filtering and statistics (grouping by date and status)
- Unit testing in `tstOrder.cs`, `tstOrderCollection`

---

## 🛠️ Technologies Used

- C# (.NET Framework)
- ASP.NET Web Forms
- SQL Server (hosted by DMU)
- Visual Studio 2022
- GitHub & Git for version control
- Bootstrap 5 (styling)
- Enterprise Architect (UML Diagrams)

---

## ✅ Features Implemented

- Robust `clsOrder` class with properties:
  - `OrderID`, `CustomerID`, `ProductID`, `OrderDate`, `TotalPrice`, `OrderStatus`, `IsCancelled`
- `Validate()` method for input validation
- `Find()` method for searching orders
- Order listing, filtering by status, deletion, and editing
- Statistics page with two GridViews (grouped by date and status)
- Fully styled UI with modern UI/UX design
- Navigation integrated with `TeamMainMenu.aspx`
- Responsive design and transitions using Bootstrap

---

## 🚀 How to Run the Project

1. Open the solution `.sln` file in **Visual Studio 2022**.
2. Ensure SQL Server contains the `tblOrder` table (with appropriate test data).
3. Start from `TeamMainMenu.aspx` to navigate the system.
4. Use the forms to add, edit, filter, and delete orders.
5. Run unit tests via **Test Explorer** to validate logic.

---

## 🧪 Unit Tests (tstOrder.cs)

- `TestFindMethodOK`
- `TestOrderIDFound`
- `TestCustomerIDFound`
- `TestProductIDFound`
- `TestOrderDateFound`
- `TestTotalPriceFound`
- `TestStatusFound`
- `TestValidationMethodOK`
- `TestValidationInvalidDate`
- `TestValidationMissingData`
- (Other general property and boundary tests included)

---

## 📊 System Architecture

- **Presentation Layer**: Web Forms (.aspx)
- **Middle Layer**: C# business logic in `clsOrder`, `clsOrderCollection`
- **Data Layer**: SQL Server table `tblOrder` and stored procedures
- **Test Layer**: Unit tests for backend logic

---

## 🔒 Ethical & Technical Considerations

- Data validation on both client and server sides
- Clean code and documentation
- GitHub version control with separate branches for design and features
- Accessibility and UI responsiveness
- Academic integrity maintained throughout development

---

## 🧑‍🤝‍🧑 Team Members & Components

| Member        | Component            |
|---------------|----------------------|
| **Andrzej Dul**   | Order Management     |
| **Ahmad Moeez**   | Stock Management     |
| **Yasser**        | Staff Management     |
| **Amir**          | Customer Management  |

---

## 📁 Folder Structure (Simplified)

BeyondEarth-TeamProject/
├── AdminSystem/
│   ├── OrderList.aspx
│   ├── OrderDataEntry.aspx
│   ├── OrderStatistics.aspx
│   ├── OrderConfirmDelete.aspx
│   └── TeamMainMenu.aspx
├── ClassLibrary/
│   ├── clsOrder.cs
│   └── clsOrderCollection.cs
├── OrderTest/
│   └── tstOrder.cs
└── README.md
---

## 📄 License

This project is for educational use under the CTEC2714 module at De Montfort University. All rights reserved to the development team.

