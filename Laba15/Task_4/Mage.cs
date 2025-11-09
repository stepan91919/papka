using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Mage : IAttack, IHeal
    {
        public string Name { get; set; }

        public Mage(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} выпускает фаербол");
        }

        public void Heal()
        {
            Console.WriteLine($"{Name} лечится!");
        }
    }
}
