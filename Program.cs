namespace StudentGradeAnalys
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
        }
    }
}
