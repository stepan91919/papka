using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем животных
            Mammal lion = new Mammal("Лев", 8, "Саванна", "Мясо", "Густой", 110);
            Bird eagle = new Bird("Орел", 5, "Горы", "Мелкие животные", 2.3, "Скальный");
            Reptile snake = new Reptile("Питон", 4, "Джунгли", "Грызуны", "Чешуйчатая", 30);
            Fish shark = new Fish("Акула", 12, "Океан", "Рыба", "Гладкая", 200);

            Console.WriteLine("Каталог животных:");
            lion.DisplayInfo(); Console.WriteLine();
            eagle.DisplayInfo(); Console.WriteLine();
            snake.DisplayInfo(); Console.WriteLine();
            shark.DisplayInfo(); Console.WriteLine();

            Console.WriteLine("действия животных:");
            lion.MakeSound(); lion.FeedMilk();
            eagle.MakeSound(); eagle.Fly();
            snake.MakeSound(); snake.Sunbathe();
            shark.MakeSound(); shark.Swim();

            Console.ReadLine();
        }
    }
}
