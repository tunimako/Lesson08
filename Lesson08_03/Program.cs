// ** 3 UŽDUOTIS **

//Sukurti struktūrą Point , public laukai x ir y tik skaitymui, perduodami per konstr .
//Sukurti struktūrą Rectangle , su public laukais TopLeft, BottomRight Point tipo.Sukurti metodą bool IsPointInRectangle Point taskas

using System;

namespace Lesson08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int topLeftX, topLeftY, bottomRightX, bottomRightY, checkPointX, checkPointY;

            //Žemiau įvedamas stačiakamio dydį.
            Console.WriteLine("Įveskite stačiakampio koordinačių tašus: \n");

            Console.WriteLine("___________________________________________________________");
            Console.Write("Įveskite viršutinio kairiojo X taško koordinatę: ");
            topLeftX = IsInputInt();

            Console.Write("Įveskite viršutinio kairiojo Y taško koordinatę: ");
            topLeftY = IsInputInt();

            Console.WriteLine("___________________________________________________________");
            Console.Write("Įveskite apatinio dešniojo X taško koordinatę: ");
            bottomRightX = IsInputInt();

            Console.Write("Įveskite apatinio dešniojo Y taško koordinatę: ");
            bottomRightY = IsInputInt();
            
            Point topLeft = new Point (topLeftX, topLeftY);
            Point bottomRight = new Point(bottomRightX, bottomRightY);

            Rectangle rectangle = new Rectangle(topLeft,bottomRight);

            //Čia įvedamos ieškomo taško koordinates.

            Console.WriteLine("___________________________________________________________");
            Console.Write("Įveskite ieškomo taško X koordinatę: ");
            checkPointX = IsInputInt();

            Console.Write("Įveskite ieškomo taško Y koordinatę: ");
            checkPointY = IsInputInt();

            Point checkPoint = new Point(checkPointX, checkPointY);

            //Tikriname ar mūsų nurodytas stačiakampis yra logiškas.
            if (rectangle.IsRectangleLogic(topLeft, bottomRight))
            {
                Console.WriteLine("Pateikti stačiakampio išmatavimai yra nelogiški!");
            }
            else
            {
                //Tikriname ar mūsų nurodyto taško kooridinatės yra stačiakampyje.
                rectangle.IsPointInRectangle(topLeft, bottomRight, checkPoint);
            }
        }
        static public int IsInputInt()
        {
            int input;

            while (true)
            {
                bool inputCheck = Int32.TryParse(Console.ReadLine(), out input);

                if (inputCheck)
                {
                    return input;
                }
                else
                {
                    Console.Write("Įvesta vertė nėra skaičius, parašome pakartoti įvestį: ");
                    continue;
                }
            }
        }
    }
}
