using HomeTeach.Login.Model;

namespace HomeTeach.Login.Repository;

public interface IUserRepository
{
    public UserAccount? GetUserByAccount(string account);
}