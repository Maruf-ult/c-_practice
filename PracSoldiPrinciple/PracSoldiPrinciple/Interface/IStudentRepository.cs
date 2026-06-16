using PracSoldiPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracSoldiPrinciple.Interface
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
