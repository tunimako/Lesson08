using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_03
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public bool IsRectangleLogic(Point topLeft, Point bottomRight)
        {
            if (((topLeft.X > bottomRight.X) && (topLeft.Y > bottomRight.Y)) || ((topLeft.X > bottomRight.X) || (topLeft.Y > bottomRight.Y)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void IsPointInRectangle(Point topLeft, Point bottomRight, Point inputPoint)
        {
            if (topLeft.X <= inputPoint.X && topLeft.Y <= inputPoint.Y && bottomRight.X >= inputPoint.X && bottomRight.Y >= inputPoint.Y)
            {
                Console.WriteLine("Nurodyto taško koordinatės YRA stačiakampyje");
            }
            else
            {
                Console.WriteLine("Nurodyto taško koordinatės NĖRA stačiakampyje");
            }
        }
    }
}
