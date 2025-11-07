using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Polymorphism
{
    public class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум-бум!");
        }
    }
}
