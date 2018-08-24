using System;
using System.Collections.Generic;
using System.Text;
using Quadratic_Equation.IO;

namespace QuadraticEquation_PseudoTest.IO
{
    public class OutputWriterFake : IOutputWriter
    {
        public String Output { get; set; }

        public void Write(string output)
        {
            Output = output;
        }
    }
}
