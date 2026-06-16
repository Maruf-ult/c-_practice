namespace Lambda_expression
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> sum = (a => a + a);
            Console.WriteLine(sum(2));

            Action<string> greet = name => Console.WriteLine($"Hello {name}");
            greet("maruf");

            Predicate<int> isOkay = age => age > 10;
            Console.WriteLine(isOkay(20));

            List<Student> students = new List<Student>
            {
            new Student { Name = "Rahim", Marks = 85 },
            new Student { Name = "Karim", Marks = 35 },
            new Student { Name = "Sadia", Marks = 90 },
            new Student { Name = "Nabil", Marks = 28 }

            };

            students.Sort((a, b) => a.Marks.CompareTo(b.Marks));

            List<Student> passedOnes = students.FindAll(mark => mark.Marks >= 35);

            foreach (Student student in passedOnes)
            {
                Console.WriteLine(student.Name);
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }

            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            List<int> GreaterThan15 = numbers.FindAll(n => n > 15);
            List<int> EvenNumbers = numbers.FindAll(n => n % 2 == 0);
            numbers.Sort((a, b) => b.CompareTo(a));

           


        }
    }
}
