using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeAnalys
{
    public class StudentManager
    {
        private List<Student> _students;
        private Dictionary<string, int> _gradeMap;

        public StudentManager(List<Student> students)
        {

            _students = students;

            _gradeMap = new Dictionary<string, int>

            {
                ["A"] = 5,
                ["B"] = 4,
                ["C"] = 3,
                ["D"] = 2,
                ["E"] = 1,
                ["F"] = 0
            };
        }


        public void ShowAllStudents()
        {
            Console.WriteLine("All students:");
            _students.ForEach(s => s.StudentInformation());
            Console.WriteLine();
        }

        public void ShowAllPassedStudents()
        {
            var studentsThatPassed = _students.FindAll(s => s.Passed == true);
            Console.WriteLine("Students that passed this class: ");
            studentsThatPassed.ForEach(s =>
            {
                Console.WriteLine($"{s.Name} passed whit the grade {s.Grade}.");
            });
            Console.WriteLine();
        }

        public void ShowThisClassAverageGrade()
        {
            double averageNumeric = _students.Average(s => _gradeMap[s.Grade]);

            Console.WriteLine($"The average grade of this class is: {averageNumeric}");
            Console.WriteLine("A = 5, B = 4, C = 3, D = 2, E = 1, F = 0");
            Console.WriteLine();
        }

        public void SortStudentByGrade()
        {
            _students.Sort((studentA, studentB) => _gradeMap[studentB.Grade].CompareTo(_gradeMap[studentA.Grade]));

            Console.WriteLine("\nStudents sorted by grade (highest first):");

            foreach (var student in _students)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }
            Console.WriteLine();
        }

        public void ShowTopThreeStudents()
        {

            Console.WriteLine("\nTop 3 students:");

            var topThree = _students.Take(3).ToList();

            foreach (var student in topThree)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }

            Console.WriteLine();

        }
    }
}
