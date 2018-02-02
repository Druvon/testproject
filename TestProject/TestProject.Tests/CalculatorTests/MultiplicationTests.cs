using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests.CalculatorTests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void Positive_x_Positive()
        {
            var result = new Calculator().Multiply(3.0f, 4.0f);

            Assert.AreEqual(12.0f, result);
        }
    }
}
