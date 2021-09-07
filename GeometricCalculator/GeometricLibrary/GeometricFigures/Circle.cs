using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary.GeometricFigures
{
    internal class Circle : SomeFigure
    {
        private double radius { get; set; }

        public double Area { get; set; }

        public Circle(double rad)
        {
            radius = rad;
            Area = CalculateArea(radius);
        }
    }
}
