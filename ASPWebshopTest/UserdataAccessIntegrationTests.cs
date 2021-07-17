using ASPWebshopTest.TestAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ASPWebshopTest
{
    [TestClass]
    public class UserdataAccessIntegrationTests
    {
        [TestMethod, TestCategory("IntegrationTest")]
        public void ConnectedToDatabase_WithCorrectCredentials_ShouldReturnAConnection()
        {
            throw new NotImplementedException();
            //Arrange

            //Act

            //Assert
        }

        [TestMethod, IntegrationTest]
        public void ConnectedToDatabase_WithIncorrectCredentials_ShouldThrowSomeError()
        {
            throw new NotImplementedException();
            //Arrange

            //Act

            //Assert
        }

    }
}