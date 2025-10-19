using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Pet
    {
        private string name;
        private int energy;

        public Pet(string Name, int Energy)
        {
            name = Name;

            if (Energy >= 0 && Energy <= 100)
            {
                energy = Energy;
            }
            else
            {
                energy = 0;
                Console.WriteLine("энергия должна быть от 0 до 100");
            }
        }

        public void Play()
        {
            energy -= 20;
            if (energy < 0) 
                energy = 0;
            Console.WriteLine($"{name} играет, энергия: {energy}.");
        }

        public void Rest()
        {
            energy += 30;
            if (energy > 100) 
                energy = 100;
            Console.WriteLine($"{name} отдыхает, энергия: {energy}.");
        }

        
    }
}
