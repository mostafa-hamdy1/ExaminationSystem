using System;
using System.Collections.Generic;

namespace ExaminationSystem
{
    public class ExamList<T> where T : Exam
    {
        private List<T> exams = new List<T>();

        public void Add(T exam)
        {
            exams.Add(exam);
        }

        public T this[int index]
        {
            get { return exams[index]; }
        }

        public int Count => exams.Count;
    }
}