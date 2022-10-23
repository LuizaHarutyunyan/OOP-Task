using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Bear : Carnivore ,Herbivore

    {
        public string getType()
        {
            return "Animal";
        }

        public  string nameOfSpecies()
        {
            return "Bear";
        }
    }
}
