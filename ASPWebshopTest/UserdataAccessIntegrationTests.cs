using ASPWebshop.Exceptions;
using ASPWebshop.Pages.Models;
using ASPWebshop.Services.Implementations;
using ASPWebshop.Services.Interfaces;
using ASPWebshopTest.TestAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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