namespace Operations;

public class Calculations
{
    /// <summary>
    /// Add two numbers
    /// </summary>
    /// <param name="number1">First number</param>
    /// <param name="number2">Second number</param>
    /// <returns>The sum of the two numbers</returns>
    public static double Add(double number1, double number2)
    {
        return number1 + number2;
    }

    /// <summary>
    /// Subtract two numbers
    /// </summary>
    /// <param name="number1">First number</param>
    /// <param name="number2">Second number</param>
    /// <returns>The difference of the two numbers (number1 - number2)</returns>
    public static double Subtract(double number1, double number2)
    {
        return number1 - number2;
    }

    /// <summary>
    /// Multiply two numbers
    /// </summary>
    /// <param name="number1">First number</param>
    /// <param name="number2">Second number</param>
    /// <returns>The product of the two numbers</returns>
    public static double Multiply(double number1, double number2)
    {
        return number1 * number2;
    }

    /// <summary>
    /// Divide two numbers
    /// </summary>
    /// <param name="number1">First number (dividend)</param>
    /// <param name="number2">Second number (divisor)</param>
    /// <returns>The quotient of the two numbers</returns>
    /// <exception cref="DivideByZeroException">Thrown when number2 is zero</exception>
    public static double Divide(double number1, double number2)
    {
        if (number2 == 0.0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return number1 / number2;
    }

    /// <summary>
    /// Calculate the remainder of two numbers
    /// </summary>
    /// <param name="number1">First number (dividend)</param>
    /// <param name="number2">Second number (divisor)</param>
    /// <returns>The remainder of the division</returns>
    /// <exception cref="DivideByZeroException">Thrown when number2 is zero</exception>
    public static double Remainder(double number1, double number2)
    {
        if (number2 == 0.0)
        {
            throw new DivideByZeroException("Cannot calculate remainder with zero divisor");
        }
        return number1 % number2;
    }
}