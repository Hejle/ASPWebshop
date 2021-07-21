using ASPWebshop.Common.Models;
using ASPWebshopDatabase;
using ASPWebshopDatabase.Services;
using ASPWebshopDatabase.Services.Implementations;
using ASPWebshopTest.TestAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ASPWebshopTest
{
    [TestClass]
    public class UserdataAccessIntegrationTests
    {
        private static readonly string TestGUID = "3047220137c04ac1a6b166c208d5b22a";
        private static readonly string TestUsername = "Test";
        public IUserDataAccess _userDataAccess;

        [TestInitialize]
        public void TestInitialize()
        {
            _userDataAccess = new UserDataAccess();
            _userDataAccess.AddUser(new WebshopUser
            {
                EMail = "test@test.com",
                ID = new Guid(TestGUID),
                Password = "1234",
                Username = TestUsername
            });
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _userDataAccess.DeleteUser(new Guid(TestGUID));
        }

        [TestMethod, TestCategory("IntegrationTest")]
        public void ConnectedToExistingDatabase_ShouldReturnAConnection()
        {
            //Arrange
            using var db = new UserContext();

            //Act
            var result = db.Database.CanConnect();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod, IntegrationTest]
        public void GetUser_WithExistingUsername_ShouldReturnAUser()
        {
            //Arrange

            //Act
            var output = _userDataAccess.GetUser(TestUsername);

            //Assert
            Assert.IsNotNull(output);
            Assert.AreEqual(TestUsername, output.Username);
        }

        [TestMethod, IntegrationTest]
        public void GetUser_WithExistingGUID_ShouldReturnAUser()
        {
            //Arrange
            var guid = new Guid(TestGUID);
            //Act
            var output = _userDataAccess.GetUser(guid);

            //Assert
            Assert.IsNotNull(output);
            Assert.AreEqual(guid, output.ID);
        }

    }
}