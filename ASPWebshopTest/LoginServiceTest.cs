using ASPWebshop.Pages.Models;
using ASPWebshop.Services.Implementations;
using ASPWebshop.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASPWebshopTest
{
    [TestClass]
    public class LoginServiceTest
    {
        [TestMethod]
        public void VerifyUser_WithCorrectUserAndPassword_ReturnTrue()
        {
            //Arrange
            var mock = new Mock<IUserDataAccess>();
            mock.Setup(x => x.getUser("TestUser")).Returns(new User {Username = "TestUser", Password = "password"});
            var loginService = new LoginService(mock.Object);

            //Act
            var verified = loginService.verifyUser("TestUser", "password");

            //Assert
            Assert.IsTrue(verified);
        }

        [TestMethod]
        public void VerifyUser_WithInCorrectUserAndPassword_ReturnFalse()
        {
            //Arrange
            var mock = new Mock<IUserDataAccess>();
            mock.Setup(x => x.getUser("TestUser")).Returns(new User {Username = "TestUser", Password = "password"});
            var loginService = new LoginService(mock.Object);

            //Act
            var verified = loginService.verifyUser("TestUser", "wrongpassword");

            //Assert
            Assert.IsFalse(verified);
        }
        
    }
}