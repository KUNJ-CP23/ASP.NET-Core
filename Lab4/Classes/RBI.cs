using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    class RBI
    {
        public virtual void calculateInterest(float p, float r, float t)
        {
            float si = (p * r * t) / 100;
            Console.WriteLine($"Interest of RBI : {si}");
        }
    }
    class HDFC:RBI
    {
        public override void calculateInterest(float p, float r, float t)
        {
            float si = (p * r * t) / 100;
            Console.WriteLine($"Interest of HDFC : {si}");
        }
    }
    class SBI:RBI
    {
        public override void calculateInterest(float p, float r, float t)
        {
            float si = (p * r * t) / 100;
            Console.WriteLine($"Interest of SBI : {si}");
        }
    }
    class ICICI:RBI
    {
        public override void calculateInterest(float p, float r, float t)
        {
            float si = (p * r * t) / 100;
            Console.WriteLine($"Interest of ICICI : {si}");
        }
    }
}
