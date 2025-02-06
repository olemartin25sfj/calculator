namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(3, 2));
        Console.WriteLine(calculator.Subtract(12, 10));
        Console.WriteLine(calculator.Multiply(5, 2));
        Console.WriteLine(calculator.Divide(5, 3));
    }
}
