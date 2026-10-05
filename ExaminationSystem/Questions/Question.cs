using System;
using ExaminationSystem.Models;

namespace ExaminationSystem.Questions
{

    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }
        public int CorrectAnswerId { get; set; }

        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList();
        }

        public abstract void Display();

        public override bool Equals(object obj)
        {
            if (obj is Question other)
            {
                return this.Header == other.Header &&
                       this.Body == other.Body &&
                       this.Marks == other.Marks;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Header, Body, Marks);
        }

        public override string ToString()
        {
            return $"[{Header}] {Body} ({Marks} Marks)";
        }
    }
}