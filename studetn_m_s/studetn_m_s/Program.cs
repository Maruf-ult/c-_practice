namespace studetn_m_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Student Result Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Subject Mark");
                Console.WriteLine("3. Show One Student Result");
                Console.WriteLine("4. Show All Results");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        manager.AddStudent(id, name);
                        Console.WriteLine("Student added successfully.");
                        break;

                    case 2:
                        Console.Write("Enter student ID: ");
                        int studentId = Convert.ToInt32(Console.ReadLine());

                        Student student = manager.FindStudentById(studentId);

                        if (student != null)
                        {
                            Console.Write("Enter subject name: ");
                            string subject = Console.ReadLine();

                            Console.Write("Enter mark: ");
                            double mark = Convert.ToDouble(Console.ReadLine());

                            student.AddSubjectMark(subject, mark);
                            Console.WriteLine("Mark added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter student ID: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        Student foundStudent = manager.FindStudentById(searchId);

                        if (foundStudent != null)
                            foundStudent.ShowResult();
                        else
                            Console.WriteLine("Student not found.");
                        break;

                    case 4:
                        manager.ShowAllStudents();
                        break;

                    case 5:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
