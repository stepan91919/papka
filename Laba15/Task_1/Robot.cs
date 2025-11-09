using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Robot : IWorkable, IRechargeable
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public Robot(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public void DoWork()
        {
            
            if (Energy >= 20)
            {
                Energy -= 20;
                Console.WriteLine($"{Name} поработал. Энергия: {Energy}");
            }
            else
            {
                Console.WriteLine($"{Name} устал. Энергия: {Energy}");
            }
        }

        // зарядка
        public void Recharge()
        {
            Energy += 50;
            if (Energy > 100)
                Energy = 100; 

            Console.WriteLine($"{Name} зарядился. Энергия: {Energy}");
        }
    }
}
