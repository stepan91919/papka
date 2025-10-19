using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Pet rex = new Pet("Рекс", 150);
                rex.Play();
                rex.Rest();
                rex.Play();
            }
        }
    }
}
