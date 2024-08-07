using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Sample;

[TestFixture]
public class CalculatorFluentTests
{
    [Test]
    public void CalculatorFluentTests_Add()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 3;
        
        // Act
        var actual = calculator.Add(1, 2);

        // Assert 
        actual.Should().Be(expected).And.BePositive();
    }
    
    [Test]
    public void CalculatorFluentTests_Divided_WithZero()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Action action = () => calculator.DividedWithException(1, 0);
        action.Should().Throw<DivideByZeroException>().WithMessage("Can't Not Divided by 0");
    }
}