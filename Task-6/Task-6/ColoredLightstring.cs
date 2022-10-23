using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ColoredLightstring : Lightstring
    {
        private List<ColoredBulb> bulbs;
        public ColoredLightstring(int length)
        {
            List<ColoredBulb> bulbs = new List<ColoredBulb>();
            for (int i = 1; i <= length; i++)
            {
                bulbs.Add(ColorFactory.createColoredBulb(i));
            }
            this.bulbs = bulbs;
        }


        public void printBulbsState(int minute)
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                string state = i % 2 == 0 ? "ON" : "OFF";
                Console.WriteLine(bulbs[i].getColor() + "-" + state);
            }
        }
    }
}
