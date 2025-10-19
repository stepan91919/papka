using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class dog
    {
        private string name;
        private int age;

        public dog(string dogName, int dogAge)
        {
            name = dogName;
            if (dogAge >= 0 && dogAge <= 15)
            {
                age = dogAge;
            }
            else
            {
                age = 0;
            }
        }
        public void Bark()
        {
            Console.WriteLine($"Собака по кличке {name}, которой {age} лет(год) - гавкает ");
        }
    }
}
