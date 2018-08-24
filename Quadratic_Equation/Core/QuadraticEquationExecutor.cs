using System;
using System.Collections.Generic;
using System.Text;
using Quadratic_Equation.Exceptions;
using Quadratic_Equation.Factories;
using Quadratic_Equation.IO;
using Quadratic_Equation.Models;

namespace Quadratic_Equation.Core
{
    public class QuadraticEquationExecutor
    {
        public QuadraticEquationExecutor(IOutputWriter writer, IInputReader reader, IQuadraticEquationFactory factory)
        {
            _writer = writer;
            _reader = reader;
            _factory = factory;
        }

        public String Model { get; set; }
        public QuadraticEquationModel Equation { get; set; }
        public QuadraticEquationRoot Root { get; set; }

        public void Execute()
        {
            _writer.Write("Please insert your Equation in the format: 'ax^2 + bx + c'");

            Model = _reader.Read();
            Equation = ParseModel(Model);
            Root = _factory.CalculateRoot(Equation);

            _writer.Write(Root.ToString());
            _reader.WhaitForInput();
        }

        public QuadraticEquationModel ParseModel(String model)
        {
            var parsedModel = _factory.GetModel(model);
            if (parsedModel.IsEmty())
            {
                throw new EquationInputException("Parsing Error: incorrect input...", _writer, _reader);
            }
            return parsedModel;
        }

        private readonly IOutputWriter _writer;
        private readonly IInputReader _reader;
        private readonly IQuadraticEquationFactory _factory;
    }
}
