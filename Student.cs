namespace StudentGradeSystem;

class Student
{
    public string Name { get; set; }
    public string[] Subjects { get; set; }
    public double[] Marks { get; set; }

    public Student(string name, string[] subjects, double[] marks)
    {
        Name = name;
        Subjects = subjects;
        Marks = marks;
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (double mark in Marks)
            total += mark;
        return total;
    }

    public double GetAverage()
    {
        return GetTotal() / Marks.Length;
    }

    public string GetGrade()
    {
        double avg = GetAverage();

        if (avg >= 90) return "A+";
        else if (avg >= 80) return "A";
        else if (avg >= 70) return "B";
        else if (avg >= 60) return "C";
        else if (avg >= 50) return "D";
        else return "F";
    }

    public void PrintReport()
    {
        Console.WriteLine($"\n  Student  : {Name}");
        Console.WriteLine($"  {"Subject",-20} {"Mark",6}");
        Console.WriteLine($"  {new string('-', 28)}");

        for (int i = 0; i < Subjects.Length; i++)
            Console.WriteLine($"  {Subjects[i],-20} {Marks[i],6}");

        Console.WriteLine($"  {new string('-', 28)}");
        Console.WriteLine($"  {"Total",-20} {GetTotal(),6}");
        Console.WriteLine($"  {"Average",-20} {GetAverage(),6:F2}");
        Console.WriteLine($"  {"Grade",-20} {GetGrade(),6}");
    }
}
