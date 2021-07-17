using ASPWebshop.Exceptions;
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
        [TestMethod, TestCategory("UnitTest")]
        public void VerifyUser_WithCorrectUserAndPassword_ReturnTrue()
        {
            //Arrange
            var mock = new Mock<IUserDataAccess>();
            var userName = "TestUser";
            var password = "password";
            mock.Setup(x => x.GetUser(userName)).Returns(new WebshopUser {Username = userName, Password = password});
            var loginService = new LoginService(mock.Object);

            //Act
            var userLoginResult = loginService.VerifyUser(userName, password);

            //Assert
            Assert.IsTrue(userLoginResult.Verified);
            Assert.AreEqual(userName, userLoginResult.WebshopUser.Username);
        }

        [TestMethod, TestCategory("UnitTest")]
        [ExpectedException(typeof(UserException))]
        public void VerifyUser_WithInCorrectUserAndPassword_ReturnFalse()
        {
            //Arrange
            var mock = new Mock<IUserDataAccess>();
            var userName = "TestUser";
            var password = "password";
            var failingPassword = "wrongpassword";
            mock.Setup(x => x.GetUser(userName)).Returns(new WebshopUser { Username = userName, Password = password});
            var loginService = new LoginService(mock.Object);

            //Act
            var verified = loginService.VerifyUser(userName, failingPassword);

            // Assert - Expects exception
        }
        
    }
}