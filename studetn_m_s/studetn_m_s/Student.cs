using System;
using System.Collections.Generic;
using System.Text;

namespace studetn_m_s
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubjectMark> SubjectMarks { get; set; }
        
        public Student(int id,string name)
        {
            Id = id;
            Name = name;
            SubjectMarks = new List<SubjectMark>();
        }
    }
}
