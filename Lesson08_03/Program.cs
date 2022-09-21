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
            //Žemiau įvedamas stačiakamio dydį.
            Point topLeft = new Point(1, 1);
            Point bottomRight = new Point(5, 5);
            Rectangle rectangle = new Rectangle(topLeft,bottomRight);
            
            //Čia įvedamos tikrinamo taško koordinates, taško koordinatės.
            Point pointCheck = new Point(4, 4);

            //Tikriname ar mūsų nurodytas stačiakampis yra logiškas.
            if (rectangle.IsRectangleLogic(topLeft, bottomRight))
            {
                Console.WriteLine("Pateikti kvadrato išmatavimai yra NElogiški");
            }
            else
            {
                //Tikriname ar mūsų nurodyto taško kooridinatės yra stačiakampyje.
                rectangle.IsPointInRectangle(topLeft, bottomRight, pointCheck);
            }
        }
    }
}
