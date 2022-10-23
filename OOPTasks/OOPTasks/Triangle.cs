using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   Task1
{
    public class Triangle:Shape
    {

        private double side1;
        private double side2;
        private double side3;
        private double semiparimeter;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double perimeter()
        {
            return side1+side2+side3;
        }

        public double area()
        {
            semiparimeter= (side1 + side2 + side3)/2;
            return Math.Sqrt(semiparimeter * (semiparimeter - side1) * (semiparimeter - side2) * (semiparimeter - side3));
        }
    }
}
