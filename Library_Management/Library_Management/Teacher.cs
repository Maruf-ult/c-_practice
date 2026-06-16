using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal class Teacher : Person
    {
        public Teacher(int id, string name) : base(id, name)
        {
        }

        public override int GetBorrowedLimit()
        {
            return 5;
        }
    }
}
