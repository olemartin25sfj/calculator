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
            throw new DivideByZeroException("Kan ikke dele på null.");
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
