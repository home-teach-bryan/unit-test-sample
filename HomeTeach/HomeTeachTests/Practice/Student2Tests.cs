using HomeTeach;

namespace HomeTeachTests.Practice;

[TestFixture]
public class Student2Tests
{
    [Test]
    public void Student2Tests_CompareTwoStudent()
    {
        // Arrange
        var student1 = new Student2 { Id = 1, Name = "Marry", Address = "Address1" };
        var student2 = new Student2 { Id = 1, Name = "Marry", Address = "Address1" };
        
        // Act & Assert two object are equals
        throw new NotImplementedException();
    }

    [Test]
    public void Student2Tests_CompareTwoStudents_WithOrder()
    {
        // Arrange
        var expected = new List<Student2>
        {
            new Student2 { Id = 1, Name = "John", Address = "John's Home" },
            new Student2 { Id = 2, Name = "Carl", Address = "Carl's Home" },
            new Student2 { Id = 3, Name = "Peter", Address = "Peter's Home" }
        };
        var student2 = new Student2();
        
        // Act
        var actual = student2.GetAllStudents();
        
        // Assert two collection are equal with order
        throw new NotImplementedException();
    }
    
    [Test]
    public void Student2Tests_CompareTwoStudents_WithAnyOrder()
    {
        // Arrange
        var expected = new List<Student2>
        {
            new Student2 { Id = 1, Name = "John", Address = "John's Home" },
            new Student2 { Id = 3, Name = "Peter", Address = "Peter's Home" },
            new Student2 { Id = 2, Name = "Carl", Address = "Carl's Home" }
        };
        var student2 = new Student2();
        
        // Act
        var actual = student2.GetAllStudents();
        
        // Assert two collection are equal with any order
        throw new NotImplementedException();
    }
}