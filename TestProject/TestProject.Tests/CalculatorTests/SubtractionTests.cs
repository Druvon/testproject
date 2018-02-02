using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests.CalculatorTests
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void Positive_Minus_Positive()
        {
            var result = new Calculator().Subtract(3.0f, 4.0f);

            Assert.AreEqual(-1.0f, result);
        }

        [TestMethod]
        public void Negative_Minus_Positive()
        {
            var result = new Calculator().Subtract(-3.0f, 4.0f);

            Assert.AreEqual(-7.0f, result);
        }

        [TestMethod]
        public void Negative_Minus_Negative()
        {
            var result = new Calculator().Subtract(-3.0f, -4.0f);

            Assert.AreEqual(1.0f, result);
        }

        [TestMethod]
        public void Positive_Minus_Negative()
        {
            var result = new Calculator().Subtract(3.0f, -4.0f);

            Assert.AreEqual(7.0f, result);
        }

    }
}
