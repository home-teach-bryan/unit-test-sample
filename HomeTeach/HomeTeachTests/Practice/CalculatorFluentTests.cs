using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Practice;

public class CalculatorFluentTests
{
    [Test]
    public void CalculatorTests_Add()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 3;

        // Act
        var actual = calculator.Add(1, 2);

        // Assert with FluentAssertions
        throw new NotImplementedException();
    }

    [Test]
    public void CalculatorFluentTests_Divided_WithZero()
    {
        throw new NotImplementedException();
    }
}