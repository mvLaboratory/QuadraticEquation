using System;
using Quadratic_Equation.Models;

namespace Quadratic_Equation.Factories
{
    public interface IQuadraticEquationFactory
    {
        QuadraticEquationModel GetModel(String model);
        QuadraticEquationRoot CalculateRoot(QuadraticEquationModel model);
    }
}
