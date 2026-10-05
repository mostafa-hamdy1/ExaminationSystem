using System;
namespace ExaminationSystem
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int timeInMinutes, int numberOfQuestions, string logFileName)
            : base(timeInMinutes, numberOfQuestions, logFileName)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("=== PRACTICE EXAM ===");
            int totalMarks = 0;
            int userGrade = 0;

            foreach (var q in Questions)
            {
                q.Display();
                Console.Write("Your Answer (Enter Answer ID): ");
                int userAns = int.Parse(Console.ReadLine());

                totalMarks += q.Marks;
                if (userAns == q.CorrectAnswerId)
                {
                    userGrade += q.Marks;
                }
                Console.WriteLine($"-> Correct Answer ID is: {q.CorrectAnswerId}\n");
            }

            Console.WriteLine($"Your Total Score: {userGrade} / {totalMarks}");
        }
    }
}