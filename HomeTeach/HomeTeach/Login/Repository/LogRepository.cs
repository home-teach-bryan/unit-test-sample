namespace HomeTeach.Login.Repository;

public class LogRepository : ILogRepository
{
    private readonly List<string> _logs = new List<string>(); 
    
    public void Log(string message)
    {
        throw new NotImplementedException();
    }
    
    public int LogCount()
    {
        throw new NotImplementedException();
    }
}