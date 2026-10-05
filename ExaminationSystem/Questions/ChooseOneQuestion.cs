using System;
namespace ExaminationSystem.Questions
{

    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string header, string body, int marks)
            : base(header, body, marks)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"[{Header}] - Choose One ({Marks} Marks)");
            Console.WriteLine(Body);
            foreach (var ans in Answers.GetAnswers())
            {
                Console.WriteLine(ans);
            }
        }
    }
}