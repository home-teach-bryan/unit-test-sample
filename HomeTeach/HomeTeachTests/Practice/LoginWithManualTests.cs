namespace HomeTeachTests.Practice;

public class LoginWithManualTests
{
    [SetUp]
    public void SetUp()
    {
        /*
         * 建立出手寫的Fake物件(例如:FakeUserRepository, FakeLogRepository)
         * 並注入至UserService中
         */
    }

    [Test]
    public void Login_ShouldReturnTrue_WhenCredentialsAreCorrect()
    {
        throw new NotImplementedException();
        // arrange 

        // act 

        // assert
    }

    [Test]
    public void Login_ShouldReturnNull_WhenAccountDoesNotExist()
    {
        throw new NotImplementedException();
        // arrange 
        
        // act 
        
        // assert
    }

    [Test]
    public void Login_ShouldReturnFalse_WhenPasswordNotCorrect()
    {
        throw new NotImplementedException();
        // arrange 
        
        // act 
        
        // assert
    }

    [Test]
    public void Login_ShouldReturnFalse_AndLogTwice_WhenCredentialsEmpty()
    {
        throw new NotImplementedException();
        // arrange 
       
        // act 
       
        // assert
       
    }
}