using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Sample;

[TestFixture]
public class EmployeeTests
{
    [Test]
    public void EmployeesTests_CompareTwoEmployee()
    {
        var employee1 = new Employee { Id = 1, Name = "James", Phone = "1234" };
        var employee2 = new Employee { Id = 1, Name = "James", Phone = "1234" };
        employee1.Should().BeEquivalentTo(employee2);
        //employee1.Should().Be(employee2) will be fail, because not override object.Equals
        
    }
    
    [Test]
    public void EmployeesTests_CompareTwoEmployees()
    {
        // Arrange
        var expected = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alan", Phone = "1234" },
            new Employee { Id = 2, Name = "Kevin", Phone = "5678" },
        };
        // Act
        var employee = new Employee();
        var actual = employee.GetAllEmployees();
        
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
    
    [Test]
    public void EmployeesTests_CompareTwoEmployees_WithCondition()
    {
        // Arrange
        var expected = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alan", Phone = "aaaa" },
            new Employee { Id = 2, Name = "Kevin", Phone = "bbbb" },
        };
        // Act
        var employee = new Employee();
        var actual = employee.GetAllEmployees();
        
        // Assert
        actual.Should().Equal(expected, (obj1, obj2) => obj1.Id == obj2.Id);
        //actual.Should().Equal(expected) will be fail, because not override object.Equals
    }
}