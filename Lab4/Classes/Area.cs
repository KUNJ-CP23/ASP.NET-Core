using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    class Area
    {
        public void Square(int side)
        {
            int a = side * side;
            Console.WriteLine($"Area of Square : {a}");
        }
        public void Rectangle(int l, int b)
        {
            int a = l * b;
            Console.WriteLine($"Area of Rectangle : {a}");
        }
    }
}
