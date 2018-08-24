using System;

namespace Quadratic_Equation.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }
    }
}
