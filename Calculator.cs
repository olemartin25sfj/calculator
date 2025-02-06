public class Calculator : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Kan ikke dele på null");
            throw new Exception("Program avsluttet!");
        }
        return a / b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}