// ** 4 UŽDUOTIS **

//Sukurti struktūrą Miskas, su public lauku medžiai List <int> tipo.
//Struktūroje yra metodas public void PasodintiMedį(). Jis prideda medį į sąrašą.

using System;
using System.Collections.Generic;

namespace Lesson08_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> labanoras = new List<string>();
            Miskas miskas = new Miskas(labanoras);
            
            Console.WriteLine("Prašome suvesti medžius (baigus suvedimą įveskite - n): ");

            string medis = Console.ReadLine();

            while (true)
            {
                miskas.PasodintiMedi(medis);
                medis = Console.ReadLine();

                if (medis == "n")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.Write("Pasodinti medžiai: ");
            foreach (string med in labanoras)
            {
                Console.Write($"{med}, ");
            }

            Console.WriteLine("");
            Console.WriteLine($"Viso pasodinta: {labanoras.Count} medžiai.");
        }
    }
}