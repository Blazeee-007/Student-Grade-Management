namespace StudentGradeSystem;

class GradeManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void PrintAllReports()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("        STUDENT GRADE REPORT            ");
        Console.WriteLine("========================================");

        foreach (Student s in students)
        {
            s.PrintReport();
            Console.WriteLine("  ----------------------------------------");
        }

        PrintClassSummary();
    }

    private void PrintClassSummary()
    {
        double classTotal = 0;
        Student topStudent = students[0];

        foreach (Student s in students)
        {
            classTotal += s.GetAverage();
            if (s.GetAverage() > topStudent.GetAverage())
                topStudent = s;
        }

        double classAverage = classTotal / students.Count;

        Console.WriteLine("\n  CLASS SUMMARY");
        Console.WriteLine($"  Total Students   : {students.Count}");
        Console.WriteLine($"  Class Average    : {classAverage:F2}");
        Console.WriteLine($"  Top Performer    : {topStudent.Name} ({topStudent.GetAverage():F2})");
        Console.WriteLine("========================================\n");
    }
}
