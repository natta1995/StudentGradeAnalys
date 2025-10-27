namespace StudentGradeAnalys

//    🎓 1. Studentbetyg-Analys Skapa en klass Student med egenskaperna Name, Grade och Passed(bool).
//✅ Gör en lista av studenter och använd: .FindAll() för att hitta de som klarade kursen.Average() 
//    för att räkna ut medelbetyg.Sort() för att sortera efter betyg 💡 Extra: Visa de 3 bästa studenterna med.Take(3)
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("All students:");
            students.ForEach(s => s.StudentInformation());
            Console.WriteLine();

            var studentsThatPassed = students.FindAll(s => s.Passed == true);
            Console.WriteLine("Students that passed this class: ");
            studentsThatPassed.ForEach(s => {
            Console.WriteLine($"{s.Name} passed whit the grade {s.Grade}." );
            });
            

            
        }

    }
}
