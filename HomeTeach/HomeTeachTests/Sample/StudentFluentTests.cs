using FluentAssertions;
using HomeTeach;

namespace HomeTeachTests.Sample;


[TestFixture]
public class StudentFluentTests
{
    [Test]
    public void StudentFluentTests_CompareTwoStudent()
    {
        // Arrange
        var student1 = new Student { Id = 1, Name = "John" };
        var student2 = new Student { Id = 1, Name = "John" };

        // Assert
        student1.Should().Be(student2);
    }

    [Test]
    public void StudentFluentTests_CompareTwoStudents_WithOrder()
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
        actual.Should().Equal(expected);
    }

    [Test]
    public void StudentFluentTests_CompareTwoStudents_WithAnyOrder()
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
        actual.Should().BeEquivalentTo(expected);
    }
}
