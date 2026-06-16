namespace ExtentionPractice
{
    /*
     * 

GetPassedStudents()
GetAverageMarks()
     */

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

    }

    static class StringExtensions
    {
        public static bool IsEven(this int Id)
        {
            return Id% 2 == 0;
        }
        public static bool IsOdd(this int Id)
        {
            return Id % 2 == 1;
        }
        public static string CapitalizeFirstLetter(this string st)
        {
            if (string.IsNullOrEmpty(st))
            {
                return "";
            }
            return char.ToUpper(st[0]) + st.Substring(1).ToLower();
        }
        public static string Shorten(this string text,int length)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return "";
            }
            if(length >= text.Length)
            {
                return text;
            }
            return text.Substring(0, length) + "...";
        }
    }

    static class StudentExtensions
    {
        public static bool IsPassed(this Student student)
        {
            return student.Marks >= 33;
        }

        public static string GetGrade(this Student student)
        {
            if (student.Marks >= 80)
            {
                return "A+";
            }
            else
            {
                return "F";
            }
        }

        public static List<Student>GetPassedStudent(this List<Student> student)
        {
            return student.Where(st => st.Marks>=33).ToList();
        }

        public static double GetAvgMarks(this List<Student> students)
        {
            if(students.Count == 0)
            {
                return 0;
            }
            return students.Average(st => st.Marks);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {Id=1, Name = "Rahim Hosain", Marks = 85 },
                new Student {Id=2, Name = "Karim rahman", Marks = 35 },
                new Student {Id=3, Name = "Hasan adfdf", Marks = 22 }
            };

            foreach(Student student in students)
            {
                if (student.Id.IsEven())
                {
                    Console.WriteLine("student has even id");
                }else if (student.Id.IsOdd())
                {
                    Console.WriteLine("Student has odd id");
                }
            }

            foreach(Student student in students)
            {
                if (student.IsPassed())
                {
                    Console.WriteLine(student.Name.CapitalizeFirstLetter());
                    Console.WriteLine(student.Name.Shorten(10));
                }
            }

            var passedStudent = students.GetPassedStudent();

            Console.WriteLine(passedStudent.GetAvgMarks());




        }
    }
}
