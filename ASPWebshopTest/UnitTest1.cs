using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPWebshopTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testString = null;
            Assert.IsNull(testString);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            var testString = string.Empty;
            Assert.IsNull(testString);
        }
    }
}
