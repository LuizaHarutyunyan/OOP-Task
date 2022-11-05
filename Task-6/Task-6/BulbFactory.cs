using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_6;

namespace Task6
{
    public class BulbFactory
    {

        public static ColoredBulb createColoredBulb(int position)
        {
            Color color;
            if (position % 5 == 0)
            {
                color = Color.RED;
            }
            else if (position % 4 == 0)
            {
                color = Color.BLUE;
            }
            else if (position % 3 == 0)
            {
                color = Color.GREEN;
            }
            else if (position % 2 == 0)
            {
                color = Color.YELLOW;
            }
            else
            {
                color = Color.RED;
            }

            return new ColoredBulb(color, position);
        }

        public static SimpleBulb createSimpleBulb(int position)
        {
            return new SimpleBulb(position);
        }
    }
}