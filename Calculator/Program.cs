internal class Program
{
    private static void Main(string[] args)
    {
        // Declare variables and then initialize to zero.
        double num1 = 0; double num2 = 0; double result = 0;

        // Display title as the C# console calculator app.
        Console.WriteLine("------------------------\r");
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");
        Console.WriteLine("------------------------\r");
        Console.WriteLine("Hello, World! Welcome to Ben's amazing calculator console app!\r");
        Console.WriteLine("------------------------\n");

        // Ask the user to type the first number.
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to type the second number.
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to choose an option.
        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\t+ - Add");
        Console.WriteLine("\t- - Subtract");
        Console.WriteLine("\t* - Multiply");
        Console.WriteLine("\t/ - Divide");
        Console.Write("Your option? ");

        // Calcul logic.
        switch (Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
        }

        Console.WriteLine($"The result of that addition is {result} oh mighty human master, please make good use of my unlimited knowledge");
        Console.ReadKey();
    }
}