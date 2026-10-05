# 🎓 C# .NET Online Examination System

![Examination System Banner](C#%20.NET%20Online%20Examination%20System.png)

A fully-featured, Object-Oriented **Console-based Examination System** built with **C#** and **.NET Framework**. This project demonstrates advanced software engineering practices, strong adherence to **OOP principles**, dynamic event handling, and robust data structures.

---

## 🌟 Key Features

- **Multi-Type Questions Support:**
  - `TrueOrFalseQuestion`: Handles binary true/false evaluation.
  - `ChooseOneQuestion`: Single-choice multiple-question system.
  - `ChooseAllQuestion`: Multiple-choice selection mechanism.
- **Dynamic Exam Generation:**
  - `PracticeExam`: Displays questions alongside correct answers and logs user performance.
  - `FinalExam`: Conducts a timed/structured test and presents final results upon completion.
- **Generic Exam Management:** Custom generic list `ExamList<T>` with type constraints for efficient exam handling.
- **Event-Driven Architecture:** Utilizes C# Delegates & Events (`ExamStarted`) to notify registered `Student` instances automatically when an exam begins.
- **Extensible Architecture:** Implements C# standard interfaces (`IComparable`, `ICloneable`) and method overriding (`Equals`, `GetHashCode`, `ToString`).
- **Activity Logging:** Generates output text logs for exam transactions and execution history.

---

## 🏗️ Technical Architecture & Design Patterns

The project follows a clean, modular folder structure for scalability and maintainability:

```text
ExaminationSystem/
│
├── Enums/          # Question & Exam Category Enums
├── Models/         # Domain Models (Subject, Student, Answer)
├── Questions/      # Question Hierarchy (Question, QuestionList, MCQ Classes)
├── Exams/          # Exam Management (Exam, PracticeExam, FinalExam, ExamList<T>)
└── Program.cs      # Entry Point & Application Driver
```

### OOP Core Concepts Applied:
- **Encapsulation:** Properties with restricted accessors and private field protection.
- **Inheritance:** Base `Question` and `Exam` abstract classes extended by specialized types.
- **Polymorphism:** Method overriding for `Display()` and customized behavior per exam type.
- **Abstraction:** Hiding complex exam execution logic behind abstract contracts.

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK 5.0+](https://dotnet.microsoft.com/)
- [Visual Studio 2022 / VS Code](https://visualstudio.microsoft.com/)

### Installation & Execution
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/ExaminationSystem.git
   ```
2. Navigate into the project folder:
   ```bash
   cd ExaminationSystem
   ```
3. Build and run the project:
   ```bash
   dotnet run
   ```

---

## 📸 Banner Preview
The repository includes visual assets representing the system architecture and analytical dashboard design for full-stack C# .NET solution workflows.

---

## 👤 Author
- **Mostafa Hamdy** - Full-Stack .NET Developer
