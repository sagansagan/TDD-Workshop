using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PalindromeTestTrue()
        {
            bool result = Worder.IsPalindrome("sirap i paris");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PalindromeTestFalse()
        {
            bool result = Worder.IsPalindrome("senap i paris");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ThrowsException()
        {
            //arrange
            string input = "";

            //Act & assert
            Assert.ThrowsException<ArgumentException>(() => Worder.IsPalindrome(input));
        }

        [TestMethod]
        public void CountLetters_EmptyString()
        {
            string word = "";

            int result = Worder.CountLetters(word);

            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void CountLetters_CountTest()
        {
            string word = "Coca-cola12345";

            int result = Worder.CountLetters(word);

            Assert.AreEqual(8, result);
        }

    }
}