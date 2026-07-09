try
{
    Console.WriteLine("===== Grades System =====");

    Console.Write("Enter student name: ");
    string studentName = Console.ReadLine();

    Console.Write("Enter grade: ");
    double grade = Convert.ToDouble(Console.ReadLine());

    if (grade < 0 || grade > 100)
    {
        Console.WriteLine("Invalid grade. Grade must be between 0 and 100.");
    }
    else if (grade >= 90)
    {
        Console.WriteLine(studentName + " got Excellent");
    }
    else if (grade >= 80)
    {
        Console.WriteLine(studentName + " got Very Good");
    }
    else if (grade >= 70)
    {
        Console.WriteLine(studentName + " got Good");
    }
    else if (grade >= 60)
    {
        Console.WriteLine(studentName + " got Pass");
    }
    else
    {
        Console.WriteLine(studentName + " got Fail");
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter a valid number for the grade.");
}