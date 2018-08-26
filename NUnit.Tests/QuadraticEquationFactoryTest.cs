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

            var expectedResult = new QuadraticEquationRoot { D = };

            var factory = new QuadraticEquationFactory();
            var actualResult = factory.CalculateRoot(model);

            Assert.IsTrue(actualResult);
        }
    }
}
