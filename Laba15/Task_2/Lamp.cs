using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Lamp : IOnOff, Ilevel

    {
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int Level { get; set; }

        public Lamp(string name)
        {
            Name = name;
            IsOn = false;
            Level = 0;
        }

        // вкл
        public void TurnOn()
        {
            IsOn = true;
            Level = 100;
            Console.WriteLine($"{Name} вкл. лвл: {Level}");
        }

        // выкл
        public void TurnOff()
        {
            IsOn = false;
            Level = 0; 
            Console.WriteLine($"{Name} выкл.");
        }

        //уровень
        public void SetLevel(int level)
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name} выкл, нельзя установить уровень.");
                return;
            }

            if (level < 0) level = 0;
            if (level > 100) level = 100;

            Level = level;
            Console.WriteLine($"{Name}: уровень установлен на {Level}");
        }
    }
}
