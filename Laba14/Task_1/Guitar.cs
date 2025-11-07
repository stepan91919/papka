using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Polymorphism
{
    public class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Брень-брень!");
        }
    }
}
