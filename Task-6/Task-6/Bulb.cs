using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public abstract class Bulb
    {
        protected int serialNumber;


        public int GetSerialNumber()
        {
            return this.serialNumber;
        }
        public Boolean IsOn(DateTime dateTime)
        {
            int minute = dateTime.Minute;
            return minute % 2 == 0 ? this.serialNumber % 2 == 0 : this.serialNumber % 2 != 0;
        }
    }
}
