using System;
using System.Collections.Generic;
using System.Text;
using Quadratic_Equation.Models;

namespace Quadratic_Equation.Factories
{
    public class QuadraticEquationFactory : IQuadraticEquationFactory
    {
        public QuadraticEquationModel GetModel(string model)
        {
            var result = new QuadraticEquationModel();
            if (string.IsNullOrEmpty(model) || !model.Contains("+"))
            {
                return result;
            }

            var operandArray = model.Split('+');
            if (operandArray.Length < 3)
            {
                return result;
            }

            var aOperand = operandArray[0].Trim();
            var aIndex = aOperand.IndexOf("x^2", StringComparison.Ordinal);
            if (aIndex < 0 || !double.TryParse(aOperand.Substring(0, aIndex), out var a))
            {
                return result;
            }

            var bOperand = operandArray[1].Trim();
            var bIndex = bOperand.IndexOf("x", StringComparison.Ordinal);
            if (bIndex < 0 || !double.TryParse(bOperand.Substring(0, bIndex), out var b))
            {
                return result;
            }

            if (!double.TryParse(operandArray[2], out var c))
            {
                return result;
            }

            result.A = a;
            result.B = b;
            result.C = c;

            return result;
        }

        public QuadraticEquationRoot CalculateRoot(QuadraticEquationModel model)
        {
            var result = new QuadraticEquationRoot();
            result.D = model.B * model.B - (4 * model.A * model.C);
            if (result.D < 0)
            {
                return result;
            }

            result.X1 = (model.B * (-1) + Math.Sqrt(result.D)) / (2 * model.A);
            result.X1 = (model.B * (-1) - Math.Sqrt(result.D)) / (2 * model.A);

            return result;
        }
    }
}
