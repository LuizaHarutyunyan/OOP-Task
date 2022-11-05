using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ColoredLightstring : Lightstring
    {


        public ColoredLightstring(int length)
        {
            List<Bulb> bulbs = new List<Bulb>();
            for (int i = 1; i <= length; i++)
            {
                bulbs.Add(BulbFactory.createColoredBulb(i));
            }
            this.bulbs = bulbs;
        }


        public override void printLightstringState()
        {
            DateTime now = DateTime.Now;
            foreach (Bulb bulb in bulbs)
            {
                string state = bulb.IsOn(now) ? "ON" : "OFF";
                Console.WriteLine(((ColoredBulb)bulb).getColor() + "-" + state);
            }
        }
    }
}
