using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz");
            int questionNumber = 1;

            foreach(Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAns(userChoice))
                {
                    _score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Wrong!, the correct ans is {question.Answer[question.CorrectAnswerIndex]}");
                }
            }
            DisplayUserResult();
        }



        private void DisplayUserResult()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|----------------------------------------------------------------|");
            Console.WriteLine("|                            Score                               |");
            Console.WriteLine("|________________________________________________________________|");
            Console.ResetColor();
            Console.WriteLine($"Your score is {_score} out of {_questions.Length}");
            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Execelent work!");
            }else if(percentage >= 0.50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing!");

            }

        }




        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|----------------------------------------------------------------|");
            Console.WriteLine("|                            Question                            |");
            Console.WriteLine("|________________________________________________________________|");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);
            for(int i = 0; i < question.Answer.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($".  {question.Answer[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.Write("Your answer(number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while(!int.TryParse(input,out choice) || choice<1 || choice > 4)
            {
                Console.WriteLine("Invalid choice, Please enter a number between 1 to 4: ");
                input = Console.ReadLine();
            }
            return choice-1;
        }
    }
}
