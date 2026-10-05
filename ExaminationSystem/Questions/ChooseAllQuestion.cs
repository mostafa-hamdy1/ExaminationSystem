using System;
namespace ExaminationSystem.Questions
{
    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string header, string body, int marks)
            : base(header, body, marks)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"[{Header}] - Choose All That Apply ({Marks} Marks)");
            Console.WriteLine(Body);
            foreach (var ans in Answers.GetAnswers())
            {
                Console.WriteLine(ans);
            }
        }
    }
}