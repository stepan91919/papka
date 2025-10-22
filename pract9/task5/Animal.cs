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
        private int age;



        public Animal(string animalName, int animalAge)
        {

            name = animalName;

            if (animalAge >= 0 && animalAge <= 50)
            {
                age = animalAge;
            }
            else
            {
                Console.WriteLine("Возраст ЗВЕРЯ должен быть от 0 до 50!!");
                age = 0;

            }
        }

        public void makeSound()

        {
            Console.WriteLine($"{name} издает вопль. (возраст: {age})");
        }

        public string getName()

        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

    }

    class Cat : Animal
    {



        private string color;

        public Cat(string catName, int catAge, string catColor) : base(catName, catAge)
        {
            color = catColor;
        }


        public void meow()
        {

            Console.WriteLine($"{getName()} (цвет: {color}) говорит: Мяу!");
        }
    }

}
