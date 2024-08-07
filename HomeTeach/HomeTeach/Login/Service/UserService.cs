using HomeTeach.Login.Model;
using HomeTeach.Login.Repository;

namespace HomeTeach.Login.Service;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly ILogRepository _logRepository;

    public UserService(IUserRepository userRepository, ILogRepository logRepository)
    {
        _userRepository = userRepository;
        _logRepository = logRepository;
    }
    /// <summary>
    /// 使用者登入
    /// </summary>
    /// <param name="account"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public bool Login(string account, string password)
    {
        if (string.IsNullOrEmpty(account))
        {
            _logRepository.Log($"{nameof(account)} can't empty");
        }
        if (string.IsNullOrEmpty(password))
        {
            _logRepository.Log($"{nameof(password)} can't empty");
        }
        var user = _userRepository.GetUserByAccount(account);
        if (user == null)
        {
            return false;
        }
        return user.Password == password;
    }
}