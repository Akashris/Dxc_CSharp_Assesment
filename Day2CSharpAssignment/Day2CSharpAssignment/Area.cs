using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpAssignment
{
    class Area
    {
        public const double pI = 3.14;
        public void CalculateArea(float x)
        {
            Console.WriteLine("Area of the square: " + x * x + " sq units");
        }
        public void CalculateArea(float x, float y)
        {
            Console.WriteLine("Area of the rectangle: " + x * y + " sq units");
        }
        public void CalculateArea(double r)
        {
            double area = pI * r * r;
            Console.WriteLine("Area of the circle: " + area + " sq units");
        }
    
    }
}
