public interface ICalculator
{
    /// <summary>
    /// double type metode
    /// </summary>
    /// <param name="a">verdien av tallet a</param>
    /// <param name="b">verdien av tallet b</param>
    /// <returns>a + b</returns>
    double Add(double a, double b);

    /// <summary>
    /// double type metode
    /// </summary>
    /// <param name="a">verdien av tallet a</param>
    /// <param name="b">verdien av tallet b</param>
    /// <returns>a - b</returns>
    double Subtract(double a, double b);

    /// <summary>
    /// double type metode
    /// </summary>
    /// <param name="a">verdien av tallet a</param>
    /// <param name="b">verdien av tallet b</param>
    /// <returns>a * b</returns>
    double Multiply(double a, double b);

    /// <summary>
    /// double type metode
    /// </summary>
    /// <param name="a">verdien av tallet a</param>
    /// <param name="b">verdien av tallet b</param>
    /// <returns>a / b</returns>
    double Divide(double a, double b);

}