using System.Collections.Generic;
namespace ExaminationSystem.Models
{ 

    public class AnswerList
    {
        private List<Answer> answers = new List<Answer>();

        public void Add(Answer answer)
        {
            answers.Add(answer);
        }

        public Answer this[int index]
        {
            get { return answers[index]; }
        }

        public int Count
        {
            get { return answers.Count; }
        }

        public List<Answer> GetAnswers()
        {
            return answers;
        }
    }
}