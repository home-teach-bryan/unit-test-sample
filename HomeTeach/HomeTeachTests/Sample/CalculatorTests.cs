using System.Diagnostics;
using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Sample;

[TestFixture]
public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup");
    }
    
    [TearDown]
    public void TearDown()
    {
        Console.WriteLine("TearDown");
    }
    
    [Test]
    public void CalculatorTests_Add()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 3;
        
        // Act
        var actual = calculator.Add(1, 2);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual, Is.Positive);
        
    }


    [Test]
    public void CalculatorTests_Minus()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 4;
        
        // Act
        var actual = calculator.Minus(5, 1);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void CalculatorTests_Multiplied()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 4;
        
        // Act
        var actual = calculator.Multiplied(2, 2);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void CalculatorTests_Divided()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 1;
        
        // Act
        var actual = calculator.Divided(2, 2);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Ignore("Temp")]
    public void CalculatorTests_Add_WithIgnore()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 4;
        
        // Act
        var actual = calculator.Add(1, 3);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Category("CalculatorAdd")]
    public void CalculatorTests_Add_One_Two_Equal_Three()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 3;
        
        // Act
        var actual = calculator.Add(1, 2);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    [Category("CalculatorAdd")]
    public void CalculatorTests_Add_Three_Four_Equal_Seven()
    {
        // Arrange
        var calculator = new Calculator();
        var expected = 7;
        
        // Act
        var actual = calculator.Add(3, 4);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(2, 3, 5)]
    [TestCase(4, 6, 10)]
    public void CalculatorTests_Add_ManyCase(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var actual = calculator.Add(a, b);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    [Test]
    public void CalculatorTests_Divided_WithZero()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        var actualException = Assert.Catch(typeof(DivideByZeroException), () => calculator.DividedWithException(1, 0));

        //Assert
        var expectedExceptionMessage = "Can't Not Divided by 0";
        Assert.That(actualException.Message, Is.EqualTo(expectedExceptionMessage));
    }

    [Test]
    public void CalculatorTests_Add_WithInternal()
    {
        // Arrange
        var calculatorInternal = new CalculatorInternal();
        var expected = 3;
        
        // Act
        var actual = calculatorInternal.Add(1, 2);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}