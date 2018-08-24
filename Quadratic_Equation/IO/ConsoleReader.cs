using System;

namespace Quadratic_Equation.IO
{
    public class ConsoleReader : IInputReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void WhaitForInput()
        {
            Console.ReadKey();
        }
    }
}
