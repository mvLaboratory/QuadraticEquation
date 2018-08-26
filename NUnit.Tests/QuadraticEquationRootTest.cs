using NUnit.Framework;
using Quadratic_Equation.Models;
using System;

namespace NUnit.Tests
{
    [TestFixture]
    public class QuadraticEquationRootTest
    {
        [Test]
        public void QuadraticEquationRoot_ToString()
        {
            var model = new QuadraticEquationRoot {D = 1, X1 = 2, X2 = 3};
            var actualResult = model.ToString();

            Assert.AreEqual(actualResult, $"D = {model.D:F3}\nx1 = {model.X1:F3}; x2 = {model.X2:F3};");
        }
    }
}
