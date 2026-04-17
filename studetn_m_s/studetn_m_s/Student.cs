using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace studetn_m_s
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubjectMark> SubjectMarks { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            SubjectMarks = new List<SubjectMark>();
        }

        public void AddSubjectMark(string subjectName, double mark)
        {
            SubjectMarks.Add(new SubjectMark(subjectName, mark));
        }

        public double CalculateTotal()
        {
            return SubjectMarks.Sum(s => s.Mark);
        }

        public double CalculateAverage()
        {
            if (SubjectMarks.Count == 0)
                return 0;

            return CalculateTotal() / SubjectMarks.Count;
        }

        public void ShowResult()
        {
            Console.WriteLine($"\nStudent ID: {Id}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine("Subjects:");

            foreach (var subject in SubjectMarks)
            {
                Console.WriteLine($"- {subject.SubjectName}: {subject.Mark}");
            }

            double total = CalculateTotal();
            double average = CalculateAverage();
            string grade = GradeCalculator.GetGrade(average);

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
    }

