using System;
namespace ExaminationSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int timeInMinutes, int numberOfQuestions, string logFileName)
            : base(timeInMinutes, numberOfQuestions, logFileName)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("=== FINAL EXAM ===");
            foreach (var q in Questions)
            {
                q.Display();
                Console.Write("Your Answer (Enter Answer ID): ");
                int userAns = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("Exam Finished. Your answers have been submitted!");
        }
    }
}