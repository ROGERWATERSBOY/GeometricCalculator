using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary.GeometricFigures
{
    internal class Triangle : SomeFigure
    {
        private double FirstSide { get; set; }

        private double SecondSide { get; set; }

        private double ThirdSide { get; set; }

        public double Area { get; set; }

        public bool IsRectangular { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            FirstSide = side1;
            SecondSide = side2;
            ThirdSide = side3;
            Area = CalculateArea(FirstSide, SecondSide, ThirdSide);
            IsRectangular = IsRectangularTriangle(side1, side2, side3) || IsRectangularTriangle(side1, side3, side2) || IsRectangularTriangle(side3, side2, side1);
        }

        private bool IsRectangularTriangle(double side1, double side2, double hypotenuse)
        {
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(hypotenuse, 2);
        }
    }
}
