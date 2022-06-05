using NUnit.Framework;

namespace DnDCore.Tests
{
    public class Tests
    {
        [Test]
        [TestCase("", true)]
        [TestCase(" ", true)]        
        public void Test_CheckUserInput_Method_ForNull(string value, bool expectedResult)
        {            
            var result = Validation.CheckUserInput(value);

            Assert.IsTrue(result == expectedResult);
            Assert.Pass();
        }

        [Test]
        [TestCase("0", false)]
        [TestCase("10", false)]
        [TestCase("100", false)]
        public void Test_CheckUserInput_Method_ForNotNull(string value, bool expectedResult)
        {
            var result = Validation.CheckUserInput(value);

            Assert.IsTrue(result == expectedResult);
            Assert.Pass();
        }
    }
}