﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone myPhone = new phone("Iphone", 20);
            myPhone.UsePhone();
            myPhone.UsePhone();
            myPhone.UsePhone();
        }
    }
}
