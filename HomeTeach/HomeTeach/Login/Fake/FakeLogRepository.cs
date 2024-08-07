using HomeTeach.Login.Repository;

namespace HomeTeach.Login.Fake;

public class FakeLogRepository : ILogRepository
{
    private readonly List<string> _logs = new List<string>();
    public void Log(string message)
    {
        this._logs.Add(message);
    }

    public int LogCount()
    {
        return _logs.Count;
    }
}