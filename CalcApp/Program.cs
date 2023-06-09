
while (true)
{
    Console.WriteLine("For starting the app enter any symbol to close enter exit");
    string appState = Console.ReadLine();

    if (!appState.Equals("exit"))
    {
        Console.Write("Enter the first number: ");
        string firstNumberInput = Console.ReadLine();
        double firstNumber;

        if (!double.TryParse(firstNumberInput, out firstNumber))
        {
            Console.WriteLine("plese enter valid number!!!");
            continue;
        }

        Console.Write("Enter the second number: ");
        string secondNumberInput = Console.ReadLine();
        double secondNumber;

        if (!double.TryParse(secondNumberInput, out secondNumber))
        {
            Console.WriteLine("plese enter valid number!!!");
            continue;
        }

        Console.Write("Enter the operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
        else if (operation == "-")
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        else if (operation == "*")
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        else if (operation == "/")
        {
            if (secondNumber != 0)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter a valid operation.");
        }
    }
    else
    {
        Console.WriteLine("Thanks for using the app.");
        break;
    }
}
