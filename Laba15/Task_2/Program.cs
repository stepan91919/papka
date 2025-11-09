using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            
            List<IOnOff> devices = new List<IOnOff>()
        {
            new Lamp("Лампа у кровати"),
            new Fan("Вентилятор в комнате")
        };

         
            foreach (var device in devices)
            {
                device.TurnOn(); 

                //  устанавливаем уровень
                if (device is Ilevel levelble)
                {
                    levelble.SetLevel(30);
                }

                device.TurnOff();
                Console.WriteLine();
            }
        }
    }
}
