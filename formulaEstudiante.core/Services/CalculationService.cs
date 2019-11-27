using System;
using System.Collections.Generic;
using System.Text;

namespace formulaEstudiante.core.Services
{
    public class CalculationService : ICalculationService
    {
        
        public double formulaCalculationX1(double a, double b, double c )
        {


           return ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
        }

        public double formulaCalculationX2(double a, double b, double c)
        {


            return ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
        }
    }

}
