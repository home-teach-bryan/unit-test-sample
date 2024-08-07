namespace HomeTeach;

public class Employee
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Phone { get; set; }

    public List<Employee> GetAllEmployees()
    {
        var result = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alan", Phone = "1234" },
            new Employee { Id = 2, Name = "Kevin", Phone = "5678" },
        };
        return result;
    }
}