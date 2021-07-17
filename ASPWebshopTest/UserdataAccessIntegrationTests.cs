using ASPWebshopTest.TestAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ASPWebshopTest
{
#pragma warning disable S2699 // Tests should include assertions
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
#pragma warning restore S2699 // Tests should include assertions
}