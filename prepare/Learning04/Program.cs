using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment wa = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());

    }
}