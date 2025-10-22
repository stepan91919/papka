using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Animal
    {
        private string name;

        public Animal(string animalName)
        {
            name = animalName;
        }

        public void speak()
        {
            Console.WriteLine($"{name} мяукает.");
        }

        public string getName()
        {
            return name;
        }
    }

    class Cat : Animal
    {
        private int lives;

        public Cat(string catName, int catLives) : base(catName)
        {
            if (catLives >= 1 && catLives <= 9)
            {
                lives = catLives;
            }
            else
            {
                Console.WriteLine("Количество жизней должно быть от 1 до 9");
                lives = 9;
            }
        }

        public Cat(string catName) : this(catName, 9)
        {
        }

        public void meow()
        {
            if (lives > 1)
            {
                lives--;
            }
            Console.WriteLine($"{getName()} мяукнул и теперь осталось жизней: {lives}.");
        }
    }
}
