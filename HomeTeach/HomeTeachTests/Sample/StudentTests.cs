using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Sample;

[TestFixture]
public class StudentTests
{
    [Test]
    public void StudentTests_CompareTwoStudent()
    {
        var student1 = new Student { Id = 1, Name = "John" };
        var student2 = new Student { Id = 1, Name = "John" };

        // Assert
        Assert.That(student1, Is.EqualTo(student2));
    }
    
    [Test]
    public void StudentTests_CompareTwoStudents_WithOrder()
    {
        // Arrange
        var expected = new List<Student>
        {
            new Student { Id = 3, Name = "Andy" },
            new Student { Id = 4, Name = "Steven" },
        };
        var student = new Student();
        
        // Act
        var actual = student.GetAllStudents();
        
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void StudentTests_CompareTwoStudents_WithAnyOrder()
    {
        // Arrange
        var expected = new List<Student>
        {
            new Student { Id = 4, Name = "Steven" },
            new Student { Id = 3, Name = "Andy" },
        };
        var student = new Student();
        
        // Act
        var actual = student.GetAllStudents();
        
        // Assert
        CollectionAssert.AreEquivalent(expected, actual);
    }
}