using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Warrior : IAttack
    {
        public string Name { get; set; }

        public Warrior(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} атакует мечом");
        }
    }
}
