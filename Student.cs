using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeAnalys
{
    public class Student
    {
        public string Name;
        public string Grade;
        public bool Passed; 

        public Student(string name, string grade, bool passed)
        {
            Name = name;
            Grade = grade;
            Passed = passed; 
        }

        public void StudentInformation()
        {
            Console.WriteLine($"Student { Name } Grade: {Grade } Passes: {Passed}");
        }
    }


}
