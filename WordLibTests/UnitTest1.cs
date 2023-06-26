using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PalindromeTest()
        {
            bool result = Worder.IsPalindrome("madam");
            Assert.IsTrue(result);
        }


    }
}