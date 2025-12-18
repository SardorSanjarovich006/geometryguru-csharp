# GeometryGuru

## 📐 Project Description

**GeometryGuru** is a C#/.NET solution designed to calculate areas and perimeters of common geometric shapes. The project follows a clean architecture approach with separate layers for Application, Domain, Infrastructure, and Client.

---

## 🚀 Features

* Calculate **area** and **perimeter** of:

  * Square
  * Parallelogram
  * Trapezoid
  * Triangle (perimeter)
* Clean separation of concerns (Domain, Application, Infrastructure)
* Easily extendable for new geometric shapes

---

## 🧱 Project Structure

```
GeometryGuru
│
├── GeometryGuru.Application
│   └── Services
│       └── GeometryService.cs
│
├── GeometryGuru.Domain
│   └── Models
│       └── Geometry.cs
│
├── GeometryGuru.Infrastructure
│   └── Data
│       └── DbContext.cs
│
├── GeometryGuru.Client
│   └── Program.cs
│
└── .gitignore
```

---

## 🛠️ Technologies Used

* C#
* .NET 6 / .NET 7 (depending on your setup)
* Visual Studio
* Git & GitHub

---

## ▶️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/USERNAME/GeometryGuru.git
```

2. Open the solution in **Visual Studio**

3. Set `GeometryGuru.Client` as **Startup Project**

4. Run the application

---

## 🧪 Example Usage

```csharp
var service = new GeometryService();
double area = service.SquareArea(5);
double perimeter = service.SquarePerimeter(5);
```

---

## 🤝 Contribution

1. Fork the repository
2. Create a new branch (`feature/new-feature`)
3. Commit your changes
4. Open a Pull Request

---

## 📄 License

This project is for educational purposes.

---

## 👤 Author

**Sardor Sanjarovich**
