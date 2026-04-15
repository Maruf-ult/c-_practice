using System;
using System.Collections.Generic;
using System.Text;

namespace studetn_m_s
{
    internal class SubjectMark
    {
        public string SubjectName { get; set; }
        public double Mark { get; set; }

        public SubjectMark(string subjectname, double mark)
        {
            SubjectName = subjectname;
            Mark = mark;
        }

    }
}
