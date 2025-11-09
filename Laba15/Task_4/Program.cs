using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{

        class Program
        {
            static void Main()
            {
                //массив игроков 
                object[] players = new object[]
                {
                    new Warrior("мишаня"),
                    new Mage("Олежа"),
                    new Warrior("морген"),
                    new Mage("мармок")
                };

                Console.WriteLine("Все, кто умеет атаковать:");

                //атакуют все
                foreach (var player in players)
                {
                    if (player is IAttack attacker)
                    {
                        attacker.Attack();
                    }
                }

                Console.WriteLine("Теперь только те, кто умеет лечить:");

                // лечатся только те, кто может лечить
                foreach (var player in players)
                {
                    if (player is IHeal healer)
                    {
                        healer.Heal();
                    }
                }
            }
        }
    }
