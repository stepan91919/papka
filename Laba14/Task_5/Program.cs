using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Players
{
    // базовый класс
    public class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }

    // класс Воин
    public class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }

    // класс Лучник
    public class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] team = { new Warrior(), new Archer(), new Player() };

            foreach (var p in team)
                p.Attack();

            Console.ReadLine();
        }
    }
}
