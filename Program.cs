namespace StudentGradeSystem;

class Program
{
    static void Main(string[] args)
    {
        GradeManager manager = new GradeManager();

        Console.WriteLine("========================================");
        Console.WriteLine("     STUDENT GRADE MANAGEMENT SYSTEM    ");
        Console.WriteLine("========================================");

        Console.Write("\nHow many students? ");
        int studentCount = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("How many subjects? ");
        int subjectCount = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("\nEnter subject names:");
        string[] subjects = new string[subjectCount];
        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write($"  Subject {i + 1}: ");
            subjects[i] = Console.ReadLine() ?? $"Subject {i + 1}";
        }

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"\nEnter name of student {i + 1}: ");
            string name = Console.ReadLine() ?? $"Student {i + 1}";

            double[] marks = new double[subjectCount];

            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write($"  {subjects[j]} mark: ");
                marks[j] = double.Parse(Console.ReadLine() ?? "0");
            }

            manager.AddStudent(new Student(name, subjects, marks));
        }

        manager.PrintAllReports();
    }
}
