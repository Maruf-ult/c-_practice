using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal class Student : Person
    {
        public Student(int id, string name) : base(id, name)
        {
        }

        public override int GetBorrowedLimit()
        {
            return 3;
        }
    }

}
