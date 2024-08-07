namespace HomeTeach.Login.Repository;

public interface ILogRepository
{
    public void Log(string message);

    public int LogCount();
}