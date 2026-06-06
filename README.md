# 🧪 TDD T-Student — C# & xUnit

Práctica APE - Metodologías Ágiles | Universidad Técnica de Ambato - FISEI  
Implementación progresiva del estadístico T-Student aplicando el ciclo **Red → Green → Refactor**

---

## 📋 Descripción

Este proyecto implementa el cálculo del **estadístico T-Student** utilizando la metodología **Test-Driven Development (TDD)** con C# y xUnit. Cada método fue desarrollado escribiendo primero la prueba (RED), luego implementando el código mínimo (GREEN) y finalmente mejorando la legibilidad (REFACTOR).

---

## 🏗️ Estructura del Proyecto
tdd-tstudent-csharp/
├── TStudentLib/          # Librería con la lógica de cálculo
│   └── Class1.cs         # Clase TStudentCalculator
├── TStudentTests/        # Proyecto de pruebas xUnit
│   └── UnitTest1.cs      # 10 pruebas unitarias
├── TStudentTDD.slnx      # Solución .NET
├── .gitignore
└── README.md

---

## ✅ Pruebas Implementadas

| # | Prueba | Método |
|---|--------|--------|
| 1 | Media de una muestra | `CalcularMedia()` |
| 2 | Varianza muestral | `CalcularVarianza()` |
| 3 | Desviación estándar | `CalcularDesviacionEstandar()` |
| 4 | Estadístico T-Student | `CalcularTStudent()` |
| 5 | Dos muestras independientes | `CalcularTStudentDosMuestras()` |
| 6 | Validar muestra vacía | `CalcularMedia()` → `ArgumentException` |
| 7 | Validar muestra con un dato | `CalcularVarianza()` → `ArgumentException` |
| 8 | Validar entrada nula | `CalcularMedia()` → `ArgumentException` |
| 9 | Verificación contra cálculo manual | `CalcularTStudent()` |
| 10 | Refactorización sin alterar resultados | Todos los métodos |

---

## 🚀 Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code
- Git Bash

---

## ⚙️ Instalación y Ejecución

```bash
# Clonar el repositorio
git clone https://github.com/Alexis112008/tdd-tstudent-csharp.git
cd tdd-tstudent-csharp

# Compilar la solución
dotnet build TStudentTDD.slnx

# Ejecutar todas las pruebas
dotnet test TStudentTDD.slnx

# Ejecutar pruebas con detalle
dotnet test TStudentTDD.slnx --logger "console;verbosity=detailed"
```

---

## 🔄 Ciclo TDD Aplicado
🔴 RED    → Escribir la prueba que falla
🟢 GREEN  → Implementar el código mínimo para pasar
🔵 REFACTOR → Limpiar y documentar sin romper las pruebas

---

## 📐 Fórmulas Implementadas

**Media muestral:**
$$\bar{x} = \frac{\sum x_i}{n}$$

**Varianza muestral:**
$$s^2 = \frac{\sum (x_i - \bar{x})^2}{n-1}$$

**T-Student una muestra:**
$$t = \frac{\bar{x} - \mu}{s / \sqrt{n}}$$

**T-Student dos muestras:**
$$t = \frac{\bar{x}_1 - \bar{x}_2}{\sqrt{\frac{s_1^2}{n_1} + \frac{s_2^2}{n_2}}}$$

---

## 🛠️ Tecnologías

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat&logo=dotnet&logoColor=white)
![xUnit](https://img.shields.io/badge/xUnit-2.9.3-blue?style=flat)
![GitHub](https://img.shields.io/badge/GitHub-Alexis112008-black?style=flat&logo=github)

---

## 👨‍💻 Autor

**Walter Alexis Nata Analuiza**  
Carrera de Software — FISEI  
Universidad Técnica de Ambato  
Ciclo Académico: Enero - Julio 2026

---

## 📚 Asignatura

**Metodologías Ágiles**  
Docente: Ing. Hernán Naranjo, Mg.