using GeometricLibrary.GeometricFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class FigureDeterminant
    {
        public string IsRectangular { get; set; }
        public double Calculate (params double[] arr)
        {
            int countparams = arr.Count();
            double area = 0;
            switch (countparams)
            {
                case 1:
                    Circle c = new Circle(arr[0]);
                    area = c.Area;
                    break;
                case 2:
                    area = 0;
                    break;
                case 3:
                    Triangle t = new Triangle(arr[0], arr[1], arr[2]);
                    area = t.Area;
                    IsRectangular = t.IsRectangular ? "Треугольник прямоугольный" : "Треугольник не прямоугольный";
                    break;
            }
            return area;
        }
    }
}
