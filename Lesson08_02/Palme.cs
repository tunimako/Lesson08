using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_02
{
    public class Palme
    {
        public int Amzius { get; set; }
        public int VaisiuKiekis { get; set; }

        public Palme(int amzius)
        {
            Amzius = amzius;
        }
        public int Prideti1MenAmziaus(int amzius)
        {
            return amzius++;
        }
        public void SuminisVaisiuKiekis(int amzius)
        {
            if (amzius > 5 && amzius <= 12)
            {
                for (int i = 5; i <= amzius; i++)
                {
                    VaisiuKiekis += 3;
                }
                Console.WriteLine($"Išgautas vaisių kiekis: {VaisiuKiekis}");
            }
            else if (amzius < 5)
            {
                Console.WriteLine("Medis per jaunas, kad duotų vaisių.");
            }
            else
            {
                Console.WriteLine("Medis yra miręs, todėl vaisių neduoda.");
            }
            
        }
    }
}


