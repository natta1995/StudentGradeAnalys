
using System.IO;
using System.Text.Json;
using System.Linq;

namespace StudentGradeAnalys

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "students.json";

         //   Console.WriteLine($"Saving file to: {Path.GetFullPath(path)}"); - Använde till att se om filen hittades - felsökning. 

            try
            {

                if (!File.Exists(path))
                {
                    var students = new List<Student> // Sead - data
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

                    var options = new JsonSerializerOptions { WriteIndented = true };
                    File.WriteAllText(path, JsonSerializer.Serialize(students, options));
                    Console.WriteLine(" Seed data created at students.json");
                }

                var readJson = File.ReadAllText(path);
                var loadedStudents = JsonSerializer.Deserialize<List<Student>>(readJson) ?? new();

                var handler = new StudentManager(loadedStudents);

                handler.ShowAllStudents();
                handler.ShowAllPassedStudents();
                handler.ShowThisClassAverageGrade();
                handler.SortStudentByGrade();
                handler.ShowTopThreeStudents();

            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }

    }
}
