using System;
using QuadraticEquation_PseudoTest.IO;
using Quadratic_Equation.Core;
using Quadratic_Equation.Factories;

namespace QuadraticEquation_PseudoTest
{
  class Program
  {
    static void Main(string[] args)
    {
      var reader = new InpurReaderFake() { Input = "2x^2 + 10x + 5"};
      var writer = new OutputWriterFake();

      new QuadraticEquationExecutor(writer, reader, new QuadraticEquationFactory()).Execute();

      var expectedResult = "D = 60.000\nx1 = -0.564; x2 = -4.436;";

      if (writer.Output == expectedResult)
      {
        Console.WriteLine("Test passed");        
      }
      else
      {
        Console.WriteLine($"Error!\nTest case: {reader.Input}\n\nExpected result: {expectedResult}\n\nActual: {writer.Output}");
      }

      Console.ReadKey();
    }
  }
}
