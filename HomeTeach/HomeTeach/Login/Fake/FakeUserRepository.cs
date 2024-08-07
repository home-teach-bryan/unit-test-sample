using HomeTeach.Login.Model;
using HomeTeach.Login.Repository;

namespace HomeTeach.Login.Fake;

public class FakeUserRepository : IUserRepository
{
    private readonly List<UserAccount> _userAccounts = new List<UserAccount>
    {
        new UserAccount
        {
            Account = "john",
            Password = "password"
        }
    };
    public UserAccount? GetUserByAccount(string account)
    {
        return _userAccounts.FirstOrDefault(item => item.Account == account);
    }
}