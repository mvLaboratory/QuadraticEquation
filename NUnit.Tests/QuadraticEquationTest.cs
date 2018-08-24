using NUnit.Framework;
using Quadratic_Equation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class QuadraticEquationTest
    {
        [Test]
        public void IsEmpty_True()
        {
            var model = new QuadraticEquationModel();
            var actualResult = model.IsEmty();

            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsEmpty_OneField_Test()
        {
            var model = new QuadraticEquationModel() { A = 2};
            var actualResult = model.IsEmty();

            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsEmptyAllFields_Test()
        {
            var model = new QuadraticEquationModel() { A = 2, B = 1, C = 8 };
            var actualResult = model.IsEmty();

            Assert.IsFalse(actualResult);
        }
    }
}
