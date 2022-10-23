using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ColorFactory
    {

        public static ColoredBulb createColoredBulb(int position)
        {
            string color = "";
            if(position%5 == 0)
            {
                color = "Red";
            }else if(position%4 == 0)
            {
                color = "Bluw";
            }else if (position % 3 == 0)
            {
                color = "Green";
            }else if(position%2 ==0)
            {
                color = "Yellow";
            }else
            {
                color = "Red";
            }

            return new ColoredBulb(color);
        }

    }
}
