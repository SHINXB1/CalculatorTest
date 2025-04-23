using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            double result = Calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            double result = Calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Add_WithNegativeNumbers_WorksCorrectly()
        {
            double result = Calculator.Add(-2, -3);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Subtract_WithNegativeNumbers_WorksCorrectly()
        {
            double result = Calculator.Subtract(-10, -5);
            Assert.AreEqual(-5, result);
        }
    }
}
