try
{
    Console.WriteLine("===== Calculator =====");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");

    Console.Write("Choose an operation: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;

    if (choice == 1)
    {
        result = num1 + num2;
        Console.WriteLine("Result = " + result);
    }
    else if (choice == 2)
    {
        result = num1 - num2;
        Console.WriteLine("Result = " + result);
    }
    else if (choice == 3)
    {
        result = num1 * num2;
        Console.WriteLine("Result = " + result);
    }
    else if (choice == 4)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            result = num1 / num2;
            Console.WriteLine("Result = " + result);
        }
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter valid numbers only.");
}