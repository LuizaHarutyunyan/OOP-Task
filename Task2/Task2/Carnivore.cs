using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface  Carnivore : Animal
    {
        public  void eat(Animal animal)
        {
            Console.WriteLine(this.nameOfSpecies + "eating" + animal.nameOfSpecies);
        }

     
    }
}
