namespace ConsoleApp2
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Marks { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
           {
            new Student { Id = 1, Name = "Rahim", Department = "CSE", Marks = 85 },
            new Student { Id = 2, Name = "Karim", Department = "EEE", Marks = 35 },
            new Student { Id = 3, Name = "Sadia", Department = "CSE", Marks = 90 },
            new Student { Id = 4, Name = "Nabil", Department = "BBA", Marks = 28 },
            new Student { Id = 5, Name = "Tania", Department = "EEE", Marks = 78 },
            new Student { Id = 6, Name = "Rafi", Department = "CSE", Marks = 60 },
            new Student { Id = 7, Name = "Mim", Department = "BBA", Marks = 45 },
            new Student { Id = 8, Name = "Hasan", Department = "CSE", Marks = 22 }
           };

            var cseStudent = students.Where(dept => dept.Department == "CSE").Select(name => name.Name);
            Console.WriteLine("All the cse students are:");
            foreach(var student in cseStudent)
            {
                Console.WriteLine(student);
            }

            var passedStudents = students.Where(mark => mark.Marks >= 33).Select(name => name.Name);
            Console.WriteLine("All the passed students");
            foreach (var student in passedStudents)
            {
                Console.WriteLine(student);
            }

            List<Student> markDesending = students.OrderByDescending(mark => mark.Marks).ToList();
            Console.WriteLine("All the desending marks");
            foreach (var st in markDesending)
            {
                Console.WriteLine($"name: {st.Name} dept: {st.Department} mark:{st.Marks}");
            }

            var studentsNames = students.Select(st => st.Name);
            Console.WriteLine("Only students name");
            foreach(var st in studentsNames)
            {
                Console.WriteLine(st);
            }

            double highestMark = students.Max(st => st.Marks);

            var topStudent = students
                .FirstOrDefault(st => st.Marks == highestMark);

            Console.WriteLine($"The top student is {topStudent.Name} with {topStudent.Marks}");

            double avgMark = students.Average(st => st.Marks);
            Console.WriteLine($"average mark: {avgMark}");


            int countPassedStudents = students.Count(st => st.Marks >= 33);
            Console.WriteLine(countPassedStudents);


            if(students.Any(st => st.Marks < 30))
            {
                Console.WriteLine("There is one below 30  mark");
            }
            else
            {
                Console.WriteLine("There is no one below 30 mark");
            }

            if(students.All(st => st.Marks >= 33))
            {
                Console.WriteLine("ALL stduent passed");
            }
            else
            {
                Console.WriteLine("All student not passed");
            }


            var groupedDept = students.GroupBy(st => st.Department);
            var departMentCounts = students.GroupBy(st => st.Department)
                .Select(group => new
                {
                    Department = group.Key,
                    TotalStudents = group.Count()
                });

            var avgMarksByDept = students.GroupBy(st => st.Department)
                .Select(group => new
                {
                    Department = group.Key,
                    AverageMarks = group.Average(st => st.Marks)
                });

            var studentInfo = students.Select(st => new
            {
                StudentName = st.Name,
                DepartmentName = st.Department,
                Result = st.Marks >= 33 ? "passed" : "failed"
            });




            foreach(var group in groupedDept)
            {
                Console.WriteLine($"Department: {group.Key}");

                foreach(var st in group)
                {
                    Console.WriteLine($"Name: {st.Name} - Mark:{st.Marks}");
                }
            }

            foreach(var item in departMentCounts)
            {
                Console.WriteLine($"{item.Department}- {item.TotalStudents}");
            }

            foreach(var item in avgMarksByDept)
            {
                Console.WriteLine($"{item.Department} - {item.AverageMarks}");
            }

            List<string> departments = new List<string> { "CSE", "EEE" };

            var selectedStudents = students.Where(st => departments.Contains(st.Department));

            var studetnsWithA = students.Where(st => st.Name.Contains("a"));

            var result = students.Skip(3);
            var result2 = students.Take(3);








        }
    }
}
