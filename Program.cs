using System.Transactions;

namespace StudentGradeAnalys

//    🎓 1. Studentbetyg-Analys Skapa en klass Student med egenskaperna Name, Grade och Passed(bool).
//✅ Gör en lista av studenter och använd: .FindAll() för att hitta de som klarade kursen.Average() 
//    för att räkna ut medelbetyg.Sort() för att sortera efter betyg 💡 Extra: Visa de 3 bästa studenterna med.Take(3)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My list of students:

            var students = new List<Student>
            {
                new Student("Emma", "B", false),
                new Student("Jonas", "A", true),
                new Student("Linda", "F", false),
                new Student("Jordan", "C", false),
                new Student("Sandra", "B", true),
                new Student("Leo", "F", false),
                new Student("Sandy", "D", false),
                new Student("Erin", "F", false),
                new Student("Mitch", "C", false),
            };

            // Present all students whit personal information:

            Console.WriteLine("All students:");
            students.ForEach(s => s.StudentInformation());
            Console.WriteLine();

            // Show all students that passed this "course":

            var studentsThatPassed = students.FindAll(s => s.Passed == true);
            Console.WriteLine("Students that passed this class: ");
            studentsThatPassed.ForEach(s => {
            Console.WriteLine($"{s.Name} passed whit the grade {s.Grade}." );
            Console.WriteLine();
            });

            // Show the average grade in this class:

            var gradeMap = new Dictionary<string, int> // Dictionaru är inte en metod utan mer som ex list eller så. Vi ersätter inte värdet i våra obejekt, vi säger bara att ex A är detsamma som 5
            {
                
                ["A"] = 5,
                ["B"] = 4,
                ["C"] = 3,
                ["D"] = 2,
                ["E"] = 1,
                ["F"] = 0,


            };

            double averageNumeric = students.Average(s => gradeMap[s.Grade]);

            Console.WriteLine($"The average grade of this class is: {averageNumeric}");
            Console.WriteLine("A = 5, B = 4, C = 3, D = 2, E = 1, F = 0");
            Console.WriteLine();

            // Sort students by Grade

           students.Sort((studentA, studentB) => gradeMap[studentB.Grade].CompareTo(gradeMap[studentA.Grade]));

            Console.WriteLine("\nStudents sorted by grade (highest first):");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }

            // Show the top 3 students

            Console.WriteLine("\nTop 3 students:");

            var topThree = students.Take(3).ToList();  

            foreach (var student in topThree)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }


        }

    }
}
