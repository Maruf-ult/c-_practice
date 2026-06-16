using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answer { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string questionText, string[] answer,int correctAnserIndex)
        {
            QuestionText = questionText;
            Answer = answer;
            CorrectAnswerIndex = correctAnserIndex;
            
        }
        public bool IsCorrectAns(int choice)
        {
            return choice == CorrectAnswerIndex;
        }
    }
}
