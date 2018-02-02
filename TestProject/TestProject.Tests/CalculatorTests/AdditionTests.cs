using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests.CalculatorTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void Positive_Plus_Positive()
        {
            var result = new Calculator().Add(3.0f, 4.7f);

            Assert.AreEqual(7.7f, result);
        }

        [TestMethod]
        public void Negative_Plus_Positive()
        {
            var result = new Calculator().Add(-3.0f, 4.0f);

            Assert.AreEqual(1.0f, result);
        }

        [TestMethod]
        public void Negative_Plus_Negative()
        {
            var result = new Calculator().Add(-3.0f, -4.0f);

            Assert.AreEqual(-7.0f, result);
        }

        [TestMethod]
        public void Positive_Plus_Negative()
        {
            var result = new Calculator().Add(3.0f, -4.0f);

            Assert.AreEqual(-1.0f, result);
        }

    }
}
