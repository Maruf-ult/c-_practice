using System;
using System.Collections.Generic;
using System.Text;

namespace studetn_m_s
{
    internal class GradeCalculator
    {
        public static string GetGrade(double average)
        {
            if (average >= 80) return "A+";
            if (average >= 70) return "A";
            if (average >= 60) return "A-";
            if (average >= 50) return "B";
            if (average >= 40) return "C";
            return "F";
        }
    }
}
