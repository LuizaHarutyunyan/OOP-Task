using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{   

    public class Square:Shape
    {
        private double width;
        public Square(double width)
        {
            this.width = width;
        }
        public double area()
        {
            return width*width;
        }

        public double perimeter()
        {
            return 4*width;
        }

    }
     
        
}
