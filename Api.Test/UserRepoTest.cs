namespace Api.Test;

using Moq;
using Api.Repositories;
using Api.Entities;
using Api.Enums;

[TestClass]
public class UserRepoTest
{
    // private readonly UserRepo _userRepo;
 
    // private readonly IUserRepo _userRepo; 
    [TestInitialize]
    public void SetUp()
    {
        var mockUserRepo = new Mock<UserRepo>();
        
        


    }

    [TestMethod]
    public void Test_AddUser_Successfully()
    {
        // User user = new User()
        // {
        //     email = "solitude316@gmail.com",
        //     gender = Gender.Male,
        //     firstname = "Moin",
        //     lastname = "Teng",
        //     password = "mypassword123",
        //     birthday = new DateTime(1978, 3, 16, 0, 0, 0)
        // };

        // _userRepo.Add(user);
        Assert.IsTrue(true);
    }
}