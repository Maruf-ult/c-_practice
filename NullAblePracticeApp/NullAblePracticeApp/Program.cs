namespace NullAblePracticeApp
{
    /*
     * 1. Show all students
2. If email is null, show "No email"
3. If marks is null, show "Marks not submitted"
4. Show only students whose marks are submitted
5. Calculate average marks only from submitted marks
6. Show student age only if DateOfBirth exists
     */
    class Student
    {
        public required int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Email { get; set; }
        public double ?Marks { get; set; }
        public DateTime ?DateOfBirth { get; set; }

    }
    /*
     *
1. Show all students
2. If email is null, show "No email"
3. If marks is null, show "Marks not submitted"
4. Show only students whose marks are submitted
5. Calculate average marks only from submitted marks
6. Show student age only if DateOfBirth exists
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Maruf", Email = "maruf@gmail.com", Marks = 83.3, DateOfBirth = new DateTime(2000, 5, 15) },
    new Student { Id = 2, Name = "Alice", Email = null, Marks = 91.7, DateOfBirth = new DateTime(1999, 8, 22) },
    new Student { Id = 3, Name = null, Email = "bob.smith@example.com", Marks = null, DateOfBirth = null },
    new Student { Id = 4, Name = "Charlie", Email = "charlie@example.com", Marks = 88.9, DateOfBirth = new DateTime(2000, 11, 5) },
    new Student { Id = 5, Name = "Diana", Email = null, Marks = 95.2, DateOfBirth = new DateTime(1998, 12, 18) },
    new Student { Id = 6, Name = "Eve", Email = "eve@example.com", Marks = null, DateOfBirth = null }
};
            foreach (Student student in students)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Email);
                Console.WriteLine(student.Marks);
                Console.WriteLine(student.DateOfBirth);
            }

            foreach(Student student in students)
            {
                string email = student?.Email ?? "No email";
                Console.WriteLine(email);
            }

            foreach(Student student in students)
            {
                double mark = student?.Marks ?? 0;
                if(mark == 0)
                {
                    Console.WriteLine("marks not submitted");
                }
                else
                {
                    Console.WriteLine(mark);
                }
            }

            var markedStudents = students.Where(st => st.Marks.HasValue);

            foreach( Student student in markedStudents)
            {
                Console.WriteLine(student.Name);
            }


            double avgMark = markedStudents.Average(st => st.Marks.Value);


            Console.WriteLine(avgMark);

            // ... (your existing code)

            // 6. Show student age only if DateOfBirth exists
            var dateOfBirthExists = students.Where(st => st.DateOfBirth.HasValue);
            foreach (Student student in dateOfBirthExists)
            {
                // Calculate age
                var today = DateTime.Today;
                var age = today.Year - student.DateOfBirth.Value.Year;
                if (student.DateOfBirth.Value.Date > today.AddYears(-age)) age--;

                Console.WriteLine($"{student.Name} is {age} years old");
            }


        }
    }
}
