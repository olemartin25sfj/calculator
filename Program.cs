class Program
{
    static void Main()
    {
        ICalculator calculator = new Calculator();
        Console.WriteLine("Kalkulator startet.");

        while (true)
        {
            Console.Write("Skriv inn første tall: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ugyldig input. Prøv igjen.");
                continue;
            }

            Console.Write("Velg operasjon (+, -, *, /): ");
            string? operation = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Ingen operasjon valgt. Prøv igjen.");
                continue;
            }

            Console.Write("Skriv inn andre tall: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ugyldig input. Prøv igjen.");
                continue;
            }



            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {calculator.Add(a, b)}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {calculator.Subtract(a, b)}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {calculator.Multiply(a, b)}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"{a} / {b} = {calculator.Divide(a, b)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Feil: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Ugyldig operasjon. Prøv igjen.");
                    break;
            }

            Console.Write("Ønsker du å fortsette? (y/n): ");
            string? svar = Console.ReadLine()?.Trim().ToLower();
            if (svar != "y")
            {
                Console.WriteLine("Programmet avsluttes.");
                break;
            }
        }
    }
}
