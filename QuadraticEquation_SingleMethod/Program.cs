using System;

namespace QuadraticEquation_SingleMethod
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please insert your Equation in the format: 'ax^2 + bx + c'");
      var equation = Console.ReadLine();

      //TODO:: test case: ""
      if (string.IsNullOrEmpty(equation))
      {
        _showInputError();
        return;
      }

      //TODO:: test case "asdsad"
      if (!equation.Contains("+"))
      {
        _showInputError();
        return;
      }

      var operandArray = equation.Split('+');
      //TODO:: test case: "sd+sd"
      if (operandArray.Length < 3)
      {
        _showInputError();
        return;
      }

      //TODO:: test case: "    5x^2"
      var aOperand = operandArray[0].Trim();
      var aIndex = aOperand.IndexOf("x^2", StringComparison.Ordinal);
      //TODO:: test case: "5x2"
      if (aIndex < 0)
      {
        _showInputError();
        return;
      }

      //TODO:: test case: "ax^2"
      if (!double.TryParse(aOperand.Substring(0, aIndex), out var a))
      {
        _showInputError();
        return;
      }

      //TODO:: test case: "    5x"
      var bOperand = operandArray[1].Trim();
      var bIndex = bOperand.IndexOf("x", StringComparison.Ordinal);
      //TODO:: test case: "5b"
      if (bIndex < 0)
      {
        _showInputError();
        return;
      }
      //TODO:: test case: "bx"
      if (!double.TryParse(bOperand.Substring(0, bIndex), out var b))
      {
        _showInputError();
        return;
      }

      //TODO:: test case: "c"
      if (!double.TryParse(operandArray[2], out var c))
      {
        _showInputError();
        return;
      }

      var d = b * b - (4 * a * c);
      if (d < 0)
      {
        Console.WriteLine("Discriminant is less than zero...\nPress any key to exit.");
        Console.ReadKey();
      }
      Console.WriteLine($"D = {d}\n");

      //TODO:: test case: "a=0"
      var x1 = (b * (-1) + Math.Sqrt(d)) / (2 * a);
      var x2 = (b * (-1) - Math.Sqrt(d)) / (2 * a);

      Console.WriteLine($"x1 = {x1:F3}; x2 = {x2:F3}\n");
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }

    private static void _showInputError()
    {
      Console.WriteLine("Parsing Error: incorrect input...\nPress any key to exit.");
      Console.ReadKey();
    }
  }
}
