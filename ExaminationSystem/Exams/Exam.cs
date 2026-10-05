using System;
using System.Collections.Generic;
using ExaminationSystem.Questions;
namespace ExaminationSystem
{
    public abstract class Exam : IComparable<Exam>, ICloneable
    {
        public int TimeInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public QuestionList Questions { get; set; }
        public Dictionary<Question, int> QuestionAnswerDictionary { get; set; }

        // Constructor Chaining 1
        public Exam()
        {
            Questions = new QuestionList("exam_log.txt");
            QuestionAnswerDictionary = new Dictionary<Question, int>();
        }

        // Constructor Chaining 2
        public Exam(int timeInMinutes, int numberOfQuestions, string logFileName) : this()
        {
            TimeInMinutes = timeInMinutes;
            NumberOfQuestions = numberOfQuestions;
            Questions.LogFileName = logFileName;
        }

        public abstract void ShowExam();

        public override bool Equals(object obj)
        {
            if (obj is Exam other)
            {
                return this.TimeInMinutes == other.TimeInMinutes &&
                       this.NumberOfQuestions == other.NumberOfQuestions;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TimeInMinutes, NumberOfQuestions);
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.TimeInMinutes.CompareTo(other.TimeInMinutes);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Exam Time: {TimeInMinutes} mins, Questions: {NumberOfQuestions}";
        }
    }
}