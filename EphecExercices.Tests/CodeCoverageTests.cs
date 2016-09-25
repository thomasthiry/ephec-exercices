using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EphecExercices.Tests
{
    [TestClass]
    public class CodeCoverageTests
    {
        [TestMethod]
        public void CalculateCost1()
        {
            var calculator = new Calculator();

            var cost = calculator.CalculateCost1();

            Assert.AreEqual(42, cost);
        }

        [TestMethod]
        public void CalculateCost2()
        {
            var calculator = new Calculator();

            var cost = calculator.CalculateCost2(500m);

            Assert.AreEqual(1000, cost);
        }

        [TestMethod]
        [Ignore] // Solution
        public void CalculateCost2_2()
        {
            var calculator = new Calculator();

            var cost = calculator.CalculateCost2(2000m);

            Assert.AreEqual(2000, cost);
        }

        [TestMethod]
        public void CalculateCost3()
        {
            var calculator = new Calculator();

            var cost = calculator.CalculateCost3(500m, 0.5m);

            Assert.AreEqual(1000, cost);
        }

        [TestMethod]
        [Ignore] // Solution
        public void CalculateCost3_2()
        {
            var calculator = new Calculator();

            var cost = calculator.CalculateCost3(2000m, 0.5m);

            Assert.AreEqual(3000, cost);
        }

        [TestMethod]
        [Ignore] // Solution
        public void CalculateCost3_3()
        {
            var calculator = new Calculator();

            var cost = calculator.CalculateCost3(2000m, -0.5m);

            Assert.AreEqual(2000, cost);
        }
    }
}
