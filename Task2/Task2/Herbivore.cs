using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface Herbivore : Animal
    {

        public void eat(Herbal herbal)
        {
            Console.WriteLine(this.nameOfSpecies + "eating Herbal" );
        }

     
    }
}
