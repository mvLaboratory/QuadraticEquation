
namespace Quadratic_Equation.Models
{
    public class QuadraticEquationModel
    {
        public double A { get; set; } = 0;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;

        public bool IsEmty()
        {
            return A == 0 && B == 0 && C == 0;
        }
    }
}
