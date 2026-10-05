using System;
using ExaminationSystem;
using ExaminationSystem.Enums;
using ExaminationSystem.Models;
using ExaminationSystem.Questions;

class Program
{
    static void Main(string[] args)
    {
        Subject csharpSubject = new Subject(101, "C# & OOP");

        Student s1 = new Student(1, "Mostafa");
        Student s2 = new Student(2, "Ahmed");

        csharpSubject.ExamStarted += s1.OnExamStarted;
        csharpSubject.ExamStarted += s2.OnExamStarted;

        ExamList<Exam> examsList = new ExamList<Exam>();

        PracticeExam practice = new PracticeExam(60, 2, "practice_log.txt");
        FinalExam final = new FinalExam(90, 2, "final_log.txt");

        examsList.Add(practice);
        examsList.Add(final);

        Console.WriteLine("Select Exam Type:");
        Console.WriteLine("1. Practice Exam");
        Console.WriteLine("2. Final Exam");
        Console.Write("Enter Choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        Exam selectedExam = (choice == 1) ? examsList[0] : examsList[1];

        ChooseOneQuestion q1 = new ChooseOneQuestion("Q1", "What does OOP stand for?", 5);
        q1.Answers.Add(new Answer(1, "Object Oriented Programming"));
        q1.Answers.Add(new Answer(2, "Order Object Protocol"));
        q1.CorrectAnswerId = 1;

        TrueOrFalseQuestion q2 = new TrueOrFalseQuestion("Q2", "C# supports Multiple Class Inheritance directly.", 5);
        q2.CorrectAnswerId = 2;

        selectedExam.Questions.Add(q1);
        selectedExam.Questions.Add(q2);

        csharpSubject.CreateExam(selectedExam);

        Console.WriteLine("\n-------------------------------------------");
        csharpSubject.Mode = ExamMode.Starting;
        Console.WriteLine("-------------------------------------------\n");

        csharpSubject.SubjectExam.ShowExam();

        Console.ReadKey();
    }
}