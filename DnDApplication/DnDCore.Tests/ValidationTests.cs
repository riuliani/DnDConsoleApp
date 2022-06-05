using NUnit.Framework;

namespace DnDCore.Tests
{
    public class Tests
    {
        #region User Input Tests
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
        #endregion

        #region Convert to int Tests
        [Test]
        [TestCase(true,"",0)]
        public void Testing_ConverToString_Method_If(bool isValid, string userInput, int expectedResult)
        {
            var result = Validation.ConvertStringToInt(isValid, userInput);

            Assert.IsTrue(result == expectedResult);
            Assert.Pass();
        }

        [Test]
        [TestCase(false,"0",0)]
        [TestCase(false,"10",10)]
        [TestCase(false,"15",15)]
        [TestCase(false,"266",266)]
        [TestCase(false,"9487",9487)]
        public void Testing_ConverToString_Method_Else(bool isValid,string userInput, int expectedResult)
        {
            var result = Validation.ConvertStringToInt(isValid, userInput);

            Assert.IsTrue(result == expectedResult);
            Assert.Pass();
        }
        #endregion
    }
}