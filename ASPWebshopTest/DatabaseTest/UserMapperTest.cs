using ASPWebshop.Common.Models;
using ASPWebshopDatabase.Context.UserDatabase;
using ASPWebshopDatabase.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ASPWebshopTest.DatabaseTest
{
    [TestClass]
    public class UserMapperTest
    {
        [TestMethod, TestCategory("UnitTest")]
        public void MapWebshopUserToUser_WithWebshopUser_ShouldHaveTheSameFields()
        {
            //Arrange
            var webshopUser = new WebshopUser
            {
                EMail = "test@test.com",
                ID = Guid.NewGuid(),
                Username = "Test",
                Password = "1234"
            };

            //Act
            var output = UserMapper.MapWebshopUserToUser(webshopUser);

            //Assert
            Assert.AreEqual(webshopUser.Username, output.Username);
            Assert.AreEqual(webshopUser.EMail, output.EMail);
            Assert.AreEqual(webshopUser.Password, output.Password);
            Assert.AreEqual(webshopUser.ID, output.ID);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void MapUserToWebshopUser_WithUser_ShouldHaveTheSameFields()
        {
            //Arrange
            var user = new User
            {
                EMail = "test@test.com",
                ID = Guid.NewGuid(),
                Username = "Test",
                Password = "1234"
            };

            //Act
            var output = UserMapper.MapUserToWebshopUser(user);

            //Assert
            Assert.AreEqual(user.Username, output.Username);
            Assert.AreEqual(user.EMail, output.EMail);
            Assert.AreEqual(user.Password, output.Password);
            Assert.AreEqual(user.ID, output.ID);
        }
    }
}
