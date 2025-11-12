using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Score
    {
        private int math;
        private int russian;
        private int physics;

        // индексы предметов
        public int this[string subject]
        {
            get
            {
                if (subject == "Математика")
                    return math;
                else if (subject == "Русский")
                    return russian;
                else if (subject == "Физика")
                    return physics;
                else
                    return 0; 
            }
            set
            {
                if (subject == "Математика")
                    math = value;
                else if (subject == "Русский")
                    russian = value;
                else if (subject == "Физика")
                    physics = value;
            }
        }

        public override string ToString()
        {
            return "Математика: " + math + ", Русский: " + russian + ", Физика: " + physics;
        }
    }
}
