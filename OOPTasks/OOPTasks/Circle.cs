using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle : Shape
    {
        private double radius;
        private static  double pi = 3.14;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double area()
        {
            return 2 * pi * Math.Pow(radius, 2); 
        }

        public double perimeter()
        {
            return 2 * pi * radius; 
        }
    }
}
