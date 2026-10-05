using System;
using ExaminationSystem.Enums; 

namespace ExaminationSystem.Models
{
    public delegate void ExamStartedHandler(string subjectName, Exam exam);

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        private ExamMode mode = ExamMode.Queued;

        public event ExamStartedHandler ExamStarted;

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

        public ExamMode Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                if (mode == ExamMode.Starting)
                {
                    ExamStarted?.Invoke(SubjectName, SubjectExam);
                }
            }
        }
    }
}