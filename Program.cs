using System;

class Calculator
{
    static void Main()
    {
        // Declare variables
        double num1, num2, res;
        string opr, oprName;

        Console.WriteLine("Calculator Simple.");

        // Get the first number, validate input
        Console.WriteLine("Write the first number: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input for the first number.");
            return; // Exit if invalid
        }

        // Loop for get the operation, validate input
        Console.WriteLine("Choose an operation (+, -, *, /): ");
        while (true)
        {
            opr = Console.ReadLine();
            if (opr == "+" || opr == "-" || opr == "*" || opr == "/")
                break;
            else
                Console.WriteLine("Invalid operation. Try again.");
        }

        // Get the second number, validate input
        Console.WriteLine("Write the second number: ");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input for the second number.");
            return; // Exit if invalid
        }

        // Perform the operation based on the user choice
        switch (opr)
        {
            case "+":
                res = num1 + num2; oprName = "addition"; break;
            case "-":
                res = num1 - num2; oprName = "subtraction"; break;
            case "*":
                res = num1 * num2; oprName = "multiplication"; break;
            case "/":
                res = num1 / num2; oprName = "division"; break;
            default:
                Console.WriteLine("Invalid operation.");
                return; // Exit if invalid
        }

        // Display the results
        Console.WriteLine(oprName + " result = " + res);
    }
}
