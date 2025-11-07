using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    // рептилия
    public class Reptile : Animal
    {
        private string SkinType;       // тип кожи
        private double TempPreference; // оптимальная температура

        public Reptile(string species, int age, string habitat, string diet, string skinType, double temp)
            : base(species, age, habitat, diet)
        {
            SkinType = skinType;
            TempPreference = temp;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип кожи: {SkinType}");
            Console.WriteLine($"Любимая температура: {TempPreference}°C");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} шипит или издаёт низкие звуки.");
        }

        public void Sunbathe()
        {
            Console.WriteLine($"{Species} греется на солнце.");
        }
    }
}
