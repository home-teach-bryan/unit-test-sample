namespace HomeTeach;

public class Student2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public List<Student2> GetAllStudents()
    {
        var result = new List<Student2>
        {
            new Student2 { Id = 1, Name = "John", Address = "John's Home" },
            new Student2 { Id = 2, Name = "Carl", Address = "Carl's Home" },
            new Student2 { Id = 3, Name = "Peter", Address = "Peter's Home" }
        };
        return result;
    }
}