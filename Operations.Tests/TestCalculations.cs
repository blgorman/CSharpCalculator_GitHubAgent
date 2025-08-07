using Shouldly;

namespace Operations.Tests
{
    public class TestCalculations
    {
        [Theory]
        [InlineData(5.0, 3.0, 8.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-5.0, 3.0, -2.0)]
        [InlineData(5.0, -3.0, 2.0)]
        [InlineData(-5.0, -3.0, -8.0)]
        [InlineData(1.5, 2.5, 4.0)]
        [InlineData(10.25, 5.75, 16.0)]
        [InlineData(double.MaxValue, 0, double.MaxValue)]
        [InlineData(double.MinValue, 0, double.MinValue)]
        public void TestAdd(double number1, double number2, double expected)
        {
            // Act
            var result = Calculations.Add(number1, number2);

            // Assert
            result.ShouldBe(expected, $"Add({number1}, {number2}) should equal {expected} but got {result}");
        }

        [Theory]
        [InlineData(5.0, 3.0, 2.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-5.0, 3.0, -8.0)]
        [InlineData(5.0, -3.0, 8.0)]
        [InlineData(-5.0, -3.0, -2.0)]
        [InlineData(1.5, 2.5, -1.0)]
        [InlineData(10.25, 5.75, 4.5)]
        [InlineData(double.MaxValue, 0, double.MaxValue)]
        [InlineData(double.MinValue, 0, double.MinValue)]
        public void TestSubtract(double number1, double number2, double expected)
        {
            // Act
            var result = Calculations.Subtract(number1, number2);

            // Assert
            result.ShouldBe(expected, $"Subtract({number1}, {number2}) should equal {expected} but got {result}");
        }

        [Theory]
        [InlineData(5.0, 3.0, 15.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(-5.0, 3.0, -15.0)]
        [InlineData(5.0, -3.0, -15.0)]
        [InlineData(-5.0, -3.0, 15.0)]
        [InlineData(1.5, 2.5, 3.75)]
        [InlineData(10.25, 2.0, 20.5)]
        [InlineData(2.0, 0.0, 0.0)]
        [InlineData(0.0, 5.0, 0.0)]
        public void TestMultiply(double number1, double number2, double expected)
        {
            // Act
            var result = Calculations.Multiply(number1, number2);

            // Assert
            result.ShouldBe(expected, $"Multiply({number1}, {number2}) should equal {expected} but got {result}");
        }

        [Theory]
        [InlineData(6.0, 3.0, 2.0)]
        [InlineData(10.0, 2.0, 5.0)]
        [InlineData(-6.0, 3.0, -2.0)]
        [InlineData(6.0, -3.0, -2.0)]
        [InlineData(-6.0, -3.0, 2.0)]
        [InlineData(1.5, 0.5, 3.0)]
        [InlineData(10.25, 2.05, 5.0)]
        [InlineData(0.0, 5.0, 0.0)]
        [InlineData(7.5, 1.5, 5.0)]
        public void TestDivide(double number1, double number2, double expected)
        {
            // Act
            var result = Calculations.Divide(number1, number2);

            // Assert
            result.ShouldBe(expected, $"Divide({number1}, {number2}) should equal {expected} but got {result}");
        }

        [Theory]
        [InlineData(0.0)]
        public void TestDivide_ThrowsExceptionForZeroDivisor(double zeroDivisor)
        {
            // Arrange
            double dividend = 10.0;

            // Act & Assert
            Should.Throw<DivideByZeroException>(() => Calculations.Divide(dividend, zeroDivisor))
                .Message.ShouldBe("Cannot divide by zero");
        }

        [Theory]
        [InlineData(10.0, 3.0, 1.0)]
        [InlineData(7.0, 2.0, 1.0)]
        [InlineData(8.5, 3.0, 2.5)]
        [InlineData(-10.0, 3.0, -1.0)]
        [InlineData(10.0, -3.0, 1.0)]
        [InlineData(-10.0, -3.0, -1.0)]
        [InlineData(5.5, 2.5, 0.5)]
        [InlineData(0.0, 5.0, 0.0)]
        [InlineData(9.0, 4.0, 1.0)]
        public void TestRemainder(double number1, double number2, double expected)
        {
            // Act
            var result = Calculations.Remainder(number1, number2);

            // Assert
            result.ShouldBe(expected, $"Remainder({number1}, {number2}) should equal {expected} but got {result}");
        }

        [Theory]
        [InlineData(0.0)]
        public void TestRemainder_ThrowsExceptionForZeroDivisor(double zeroDivisor)
        {
            // Arrange
            double dividend = 10.0;

            // Act & Assert
            Should.Throw<DivideByZeroException>(() => Calculations.Remainder(dividend, zeroDivisor))
                .Message.ShouldBe("Cannot calculate remainder with zero divisor");
        }
    }
}