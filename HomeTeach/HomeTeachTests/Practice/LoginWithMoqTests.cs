namespace HomeTeachTests.Practice;

public class LoginWithMoqTests
{
    [SetUp]
    public void SetUp()
    {
        /*
         * 使用Moq框架建立出Mock物件(例如:MockUserRepository, MockLogRepository)
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
       
        // assert and assert log be executed twice
       
    }
}