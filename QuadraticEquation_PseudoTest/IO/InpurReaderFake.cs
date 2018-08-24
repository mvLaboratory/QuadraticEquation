using System;
using Quadratic_Equation.IO;

namespace QuadraticEquation_PseudoTest.IO
{
    public class InpurReaderFake : IInputReader
    {
        public String Input { get; set; } = "";

        public string Read()
        {
            return Input;
        }

        public void WhaitForInput()
        {
            return;
        }
    }
}
