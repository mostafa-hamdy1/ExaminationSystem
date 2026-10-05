# 🎓 C# .NET Online Examination System

<p align="center">
  <img src="C%23%20.NET%20Online%20Examination%20System.png" alt="Examination System Banner" width="100%" />
</p>

A fully-featured, Object-Oriented **Console-based Examination System** built with **C#** and **.NET Framework**. This project demonstrates advanced software engineering practices, strong adherence to **OOP principles**, dynamic event handling, and robust data structures.

---

## 📌 Project Overview

This application simulates a complete educational testing platform. It allows instructors to construct various question types and generate dynamic exams (Practice or Final) with automated grading, timed evaluations, and event notifications.

---

## 🌟 Key Features

- **Multi-Type Questions Support:**
  - `TrueOrFalseQuestion`: Binary true/false evaluation logic.
  - `ChooseOneQuestion`: Single-choice question management.
  - `ChooseAllQuestion`: Multiple-choice selection mechanism.
- **Dynamic Exam Generation:**
  - `PracticeExam`: Displays questions alongside correct answers and logs performance.
  - `FinalExam`: Conducts a structured test and presents final scores upon completion.
- **Generic Exam Management:** Custom generic list `ExamList<T>` with constraints for efficient handling.
- **Event-Driven Architecture:** Uses C# Delegates & Events (`ExamStarted`) to notify registered `Student` instances automatically when an exam begins.
- **Extensible Architecture:** Implements standard interfaces (`IComparable`, `ICloneable`) and method overriding (`Equals`, `GetHashCode`, `ToString`).

---

## 🛠️ Tech Stack & Architecture

- **Language:** C# (.NET Framework / .NET Core)
- **Paradigm:** Object-Oriented Programming (OOP)
- **Design Concepts:** Encapsulation, Inheritance, Polymorphism, Abstraction
- **IDE:** Visual Studio 2022 / VS Code

---

## 🏗️ Folder Structure

```text
ExaminationSystem/
│
├── Enums/          # Question & Exam Category Enums
├── Models/         # Domain Models (Subject, Student, Answer)
├── Questions/      # Question Hierarchy (Question, QuestionList, MCQ Classes)
├── Exams/          # Exam Management (Exam, PracticeExam, FinalExam, ExamList<T>)
└── Program.cs      # Entry Point & Application Driver

👤 Author

Mostafa Hamdy - Full-Stack .NET Developer
