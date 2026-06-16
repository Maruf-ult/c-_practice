using System.Collections.Generic;
using PracSoldiPrinciple.Interface;
using PracSoldiPrinciple.Model;

namespace PracSoldiPrinciple.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Rahim" },
                new Student { Id = 2, Name = "Karim" },
                new Student { Id = 3, Name = "Sadia" }
            };
        }
    }
}