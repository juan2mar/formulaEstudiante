using System;
using System.Collections.Generic;
using System.Text;

namespace formulaEstudiante.core.Services
{
    public class CalculationService : ICalculationService
    {
        
        public double formulaCalculationX1(double a, double b, double c )
        {

            var d = (Math.Pow(b, 2) - (4 * a * c));
            double total = 0;
            if (d != 0)
            {
                if (d < 0)
                {
                    total = (-1 * b) - ((Math.Sqrt(d)) / (2 * a));
                }
                else
                {
                    total = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                }
            }
            else
            {
                total = (-1 * b) / (2 * a);
            }
            return total;
        }

        public double formulaCalculationX2(double a, double b, double c)
        {
            var d = (Math.Pow(b, 2) - (4 * a * c));
            double total = 0;
            if (d != 0)
            {
                if (d < 0)
                {
                    total = (-1 * b) + ((Math.Sqrt(d)) / (2 * a));
                }
                else
                {
                    total = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                }
            }
            else
            {
                total = (-1 * b) / (2 * a);
            }
            return total;
        }
    }

}
