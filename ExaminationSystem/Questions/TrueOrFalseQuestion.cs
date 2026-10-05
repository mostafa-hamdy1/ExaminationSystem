using System;
using ExaminationSystem.Models;
namespace ExaminationSystem.Questions
{

    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, int marks)
            : base(header, body, marks)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void Display()
        {
            Console.WriteLine($"[{Header}] ({Marks} Marks)");
            Console.WriteLine(Body);
            foreach (var ans in Answers.GetAnswers())
            {
                Console.WriteLine(ans);
            }
        }
    }
}