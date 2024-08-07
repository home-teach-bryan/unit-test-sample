namespace HomeTeach;

public class Student
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public override bool Equals(object? obj)
    {
        var compare = (Student)obj;
        return compare.Id == this.Id && compare.Name == this.Name;
    }
    
    public List<Student> GetAllStudents()
    {
        var result = new List<Student>
        {
            new Student { Id = 3, Name = "Andy" },
            new Student { Id = 4, Name = "Steven" },
        };
        return result;
    }
}