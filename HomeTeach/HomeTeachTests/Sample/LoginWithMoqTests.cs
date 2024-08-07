using FluentAssertions;
using HomeTeach.Login.Model;
using HomeTeach.Login.Repository;
using HomeTeach.Login.Service;
using Moq;

namespace HomeTeachTests.Sample;

[TestFixture]
public class LoginWithMoqTests
{
    private Mock<IUserRepository> _userRepositoryMock;
    private Mock<ILogRepository> _logRepositoryMock;
    private UserService _userService;

    [SetUp]
    public void SetUp()
    {
        _userRepositoryMock = new Mock<IUserRepository>();
        _logRepositoryMock = new Mock<ILogRepository>();
        _userService = new UserService(_userRepositoryMock.Object, _logRepositoryMock.Object);
    }
    
    [Test]
    public void Login_ShouldReturnTrue_WhenCredentialsAreCorrect()
    {
        // arrange 
        var account = "john";
        var password = "password";
        var user = new UserAccount { Account = account, Password = password };
        _userRepositoryMock.Setup((mock) => mock.GetUserByAccount(account)).Returns(user);
        
        // act 
        var actual = _userService.Login(account, password);
        
        // assert
        actual.Should().BeTrue();
    }

    [Test]
    public void Login_ShouldReturnNull_WhenAccountDoesNotExist()
    {
        // arrange 
        var account = "john";
        var password = "password";
        _userRepositoryMock.Setup((mock) => mock.GetUserByAccount(account)).Returns((UserAccount?)null);
        
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
        var password = "password";
        var user = new UserAccount { Account = "john", Password = "NewPassword" };
        _userRepositoryMock.Setup((mock) => mock.GetUserByAccount(account)).Returns(user);
        
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
        _userRepositoryMock.Setup((mock) => mock.GetUserByAccount(account)).Returns((UserAccount?)null);
        
        // act 
        var actual = _userService.Login(account, password);
        
        // assert
        actual.Should().BeFalse();
        
        // assert the log be executed twice
        _logRepositoryMock.Verify((mock) => mock.Log(It.IsAny<string>()), Times.Exactly(2));
        
    }
}