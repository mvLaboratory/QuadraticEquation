namespace Quadratic_Equation.Models
{
    public class QuadraticEquationRoot
    {
        public double D { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public override string ToString()
        {
            return $"D = {D:F3}\nx1 = {X1:F3}; x2 = {X2:F3};";
        }
    }
}
