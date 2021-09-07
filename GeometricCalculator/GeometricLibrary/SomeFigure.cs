using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    internal abstract class SomeFigure
    {
        private const double Pi = Math.PI;

        protected double CalculateArea(double param1)
        {
            return Pi * Math.Pow(param1, 2);
        }

        protected double CalculateArea(double param1, double param2, double param3)
        {
            var p = 0.5*(param1 + param2 + param3);
            return Math.Sqrt(p*(p - param1)*(p - param2)*(p - param3));
        }
    }
}
