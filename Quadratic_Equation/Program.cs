using System;
using Quadratic_Equation.Core;
using Quadratic_Equation.Factories;
using Quadratic_Equation.IO;

namespace Quadratic_Equation
{
  class Program
  {
    static void Main(string[] args)
    {
      new QuadraticEquationExecutor(new ConsoleWriter(), new ConsoleReader(), new QuadraticEquationFactory()).Execute();
    }
  }
}
