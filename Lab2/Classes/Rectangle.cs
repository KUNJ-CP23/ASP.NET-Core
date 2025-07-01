using System;

namespace Lab2.Classes
{
    public class Rectangle
    {
        double Length;
        double Width;

        // Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayArea()
        {
            double area = Length * Width;
            Console.WriteLine($"\nArea of Rectangle: {area} square units");
        }
    }

}
