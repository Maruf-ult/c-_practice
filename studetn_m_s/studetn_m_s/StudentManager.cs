using System;
using System.Collections.Generic;
using System.Text;

namespace studetn_m_s
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(int id, string name)
        {
            students.Add(new Student(id, name));
        }

        public Student FindStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void ShowAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (var student in students)
            {
                student.ShowResult();
            }
        }
    }
}
