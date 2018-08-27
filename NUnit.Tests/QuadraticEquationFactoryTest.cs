using System;
using NUnit.Framework;
using Quadratic_Equation.Factories;
using Quadratic_Equation.Models;
using Rhino.Mocks;

namespace NUnit.Tests
{
    [TestFixture]
    public class QuadraticEquationFactoryTest
    {
        [Test]
        public void QuadraticEquationFactory_CalculateRoot_HappyPath()
        {
            var model = new QuadraticEquationModel() {A = 2, B = 6, C = 2};

            var expectedResult = new QuadraticEquationRoot { D = 20, X1 = -0.382, X2 = -2.618};

            var factory = new QuadraticEquationFactory();
            var actualResult = factory.CalculateRoot(model);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void QuadraticEquationFactory_CalculateRoot_NullModel()
        {
            var factory = new QuadraticEquationFactory();
            Assert.Throws<ArgumentNullException>(() => factory.CalculateRoot(null));
        }
    }
}
