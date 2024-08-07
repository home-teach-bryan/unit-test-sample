using FluentAssertions;
using HomeTeach.Login.Fake;
using HomeTeach.Login.Model;
using HomeTeach.Login.Repository;
using HomeTeach.Login.Service;

namespace HomeTeachTests.Sample;

public class LoginWIthManualTests
{
    private IUserRepository _userRepository;
    private ILogRepository _logRepository;
    private UserService _userService;

    [SetUp]
    public void SetUp()
    {
        _userRepository = new FakeUserRepository();
        _logRepository = new FakeLogRepository();
        _userService = new UserService(_userRepository, _logRepository);
    }

    [Test]
    public void Login_ShouldReturnTrue_WhenCredentialsAreCorrect()
    {
        // arrange 
        var account = "john";
        var password = "password";
        var user = new UserAccount { Account = account, Password = password };
        
        // act 
        var actual = _userService.Login(account, password);
        
        // assert
        actual.Should().BeTrue();
    }

    [Test]
    public void Login_ShouldReturnNull_WhenAccountDoesNotExist()
    {
        // arrange 
        var account = "john1";
        var password = "password";
        
        // act 
        var actual = _userService.Login(account, password);
        
        // assert
        actual.Should().BeFalse();
    }

    [Test]
    public void Login_ShouldReturnFalse_WhenPasswordNotCorrect()
    {
        // arrange 
        var account = "john";
        var password = "password1";
        
        // act 
        var actual = _userService.Login(account, password);
        
        // assert
        actual.Should().BeFalse();
    }

    [Test]
    public void Login_ShouldReturnFalse_AndLogTwice_WhenCredentialsEmpty()
    {
        // arrange 
        var account = "";
        var password = "";
        var expectedCount = 2;
        
        // act 
        var actual = _userService.Login(account, password);
        var actualCount = _logRepository.LogCount();
        // assert
        actual.Should().BeFalse();
        actualCount.Should().Be(expectedCount);
    }
}