namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[] { 
               
               new Question(
                   "What is the capital of Germany?",
                   new string[] {"paris","Berlin","London","Madrid"},
                   1
                   
                ),
               new Question(
                   "What is 2 + 2?",
                   new string[] {"1","2","4","6"},
                   2

                ),
               new Question(
                   "What is the capital of Bangladesh?",
                   new string[] {"paris","Berlin","London","Dhaka"},
                   3

                )

            };
            
            Quiz myQuiz = new Quiz( questions );
            myQuiz.StartQuiz();
            Console.ReadKey();
        }
    }
}
