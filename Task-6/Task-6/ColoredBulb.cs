using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task_6;

namespace Task6
{
    public class ColoredBulb:Bulb
    {
        private Color color;

        public ColoredBulb(Color color,int serialNumber)
        {
            this.color = color;
            this.serialNumber = serialNumber;
        }

        public Color getColor()
        {
            return this.color;
        }

    }
}
