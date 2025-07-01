using System;

namespace Lab4.Classes
{
    class Addition
    {
        public void Add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Sum of integers: " + res);
        }

        public void Add(float a, float b)
        {
            float res = a + b;
            Console.WriteLine("Sum of floats: " + res);
        }
    }
}
