// ** 2 UŽDUOTIS **

//Sukurti struktūrą Palmė.
//Public laukai: amzius ir vaisiuKiekis . Abu tik skaitymui. 
//Sukurti public metodą Prideti1MenAmziaus(). 
//Palmė duoda vaisius nuo 5 iki 12 menėsio , paskui miršta, t.y . amžius tampa 0. VaisiuKiekis = amžius * 3;

//__________________________________________________________________________________________________________
//Parašytas kodas neatitinka užduotis. Jame nepanaudojamas užduotyje nurodtas metodas Prideti1MenAmziaus()
//__________________________________________________________________________________________________________

using System;

namespace Lesson08_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amzius;

            Console.Write("Įveskite palmės amžių mėnesiais: ");

            while (true)
            {
                bool checkAmzius = Int32.TryParse(Console.ReadLine(), out amzius);

                if (checkAmzius)
                {
                    break;
                }
                else
                {
                    Console.Write("Prašome pakartotinai įvesti palmės amžių: ");
                }
            }
            Console.WriteLine("");

            Palme palme1 = new Palme(amzius);

            palme1.SuminisVaisiuKiekis(palme1.Amzius);
        }
    }
}
