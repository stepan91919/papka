using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
        class Program
        {
            static void Main()
            {

                Robot r1 = new Robot("робот джо", 60);

                
                r1.DoWork();    
                r1.DoWork();   
                r1.Recharge();  
                r1.DoWork();  

                // итог
                Console.WriteLine($"Итог: {r1.Name}, энергия: {r1.Energy}");
            }
        }
    }