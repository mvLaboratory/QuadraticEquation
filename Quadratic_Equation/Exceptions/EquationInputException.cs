using System;
using Quadratic_Equation.IO;

namespace Quadratic_Equation.Exceptions
{
    public class EquationInputException : Exception
    {
        public EquationInputException(String message) : base(message)
        {

        }

        public EquationInputException(String message, IOutputWriter writer, IInputReader reader) : base(message)
        {
            writer.Write(message);
            reader.WhaitForInput();
        }
    }
}
