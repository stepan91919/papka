using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Fan : IOnOff
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }

        public Fan(string name)
        {
            Name = name;
            IsOn = false;
        }

        // Вкл
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} включен.");
        }

        // выкл
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} выключен.");
        }
    }
}
