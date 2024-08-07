using System.Reflection.Metadata;
using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Practice;

public class EmployeeTests
{
    [Test]
    public void EmployeesTests_CompareTwoEmployee()
    {
        var employee1 = new Employee { Id = 1, Name = "James", Phone = "1234" };
        var employee2 = new Employee { Id = 1, Name = "James", Phone = "1234" };
        
        // Assert employee1 and employee2 are equivalent with FluentAssertions
        throw new NotImplementedException();
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
        
        // Assert expected and actual are equivalent with FluentAssertions
        throw new NotImplementedException();
    }
    
    [Test]
    public void EmployeesTests_CompareTwoEmployees_WithCondition()
    {
        // Arrange
        var expected = new List<Employee>
        {
            new Employee { Id = 1, Name = "Judy", Phone = "1234" },
            new Employee { Id = 2, Name = "Lily", Phone = "5678" },
        };
        
        // Act
        var employee = new Employee();
        var actual = employee.GetAllEmployees();
        
        // Assert expected and actual are equivalent with FluentAssertions and conditions
        throw new NotImplementedException();
    }
}