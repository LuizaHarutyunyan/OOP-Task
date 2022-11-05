using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6;

namespace Task_6
{
    public class SimpleLightstring : Lightstring
    {
        public SimpleLightstring(int length)
        {
            List<Bulb> bulbs = new List<Bulb>();
            for (int i = 1; i <= length; i++)
            {
                bulbs.Add(BulbFactory.createSimpleBulb(i));
            }
            this.bulbs = bulbs;
           
        }
        public override void printLightstringState()
        {
            DateTime now = DateTime.Now;
            foreach (Bulb bulb in bulbs)
            {
                string state = bulb.IsOn(now) ? "ON" : "OFF";
                Console.WriteLine(bulb.GetSerialNumber() + "bulb is -"+state);
            }
        }
    }
}
