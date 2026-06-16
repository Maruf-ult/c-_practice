using PracSoldiPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using PracSoldiPrinciple.Repository;

namespace PracSoldiPrinciple.Service
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void ShowStudents()
        {
            var students = _repository.GetStudents();

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
