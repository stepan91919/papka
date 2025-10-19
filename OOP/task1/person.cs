using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class person
    {
        private int age;
        private string name;

        public person(int ageHuman, string nameHuman)
        {
            name = nameHuman;
            if (ageHuman >= 0 && ageHuman <= 120)
            {
                age = ageHuman;
            }
            else
            {
                Console.WriteLine("Возраст должен быть от 0 до 120!");
            }
            
        }
        public void sayHello()
        {
            {
                Console.WriteLine($"привет, меня зовут {name}, мне {age} лет(год)");
            }
        }
    }
}
