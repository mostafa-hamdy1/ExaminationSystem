using System;
namespace ExaminationSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
        }

        public void OnExamStarted(string subjectName, Exam exam)
        {
            Console.WriteLine($"[Notification for Student {StudentName}]: The exam for '{subjectName}' has STARTED! Time: {exam.TimeInMinutes} mins.");
        }
    }
}