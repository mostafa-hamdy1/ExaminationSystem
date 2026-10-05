using System;
using System.Collections.Generic;
using System.IO;
namespace ExaminationSystem.Questions
{
    public class QuestionList : List<Question>
    {
        public string LogFileName { get; set; }

        public QuestionList(string logFileName)
        {
            LogFileName = logFileName;
        }

        public new void Add(Question question)
        {
            base.Add(question);

            using (StreamWriter writer = new StreamWriter(LogFileName, true))
            {
                writer.WriteLine($"[{DateTime.Now}] Added Question: {question.Header} - {question.Body} (Marks: {question.Marks})");
            }
        }
    }
}