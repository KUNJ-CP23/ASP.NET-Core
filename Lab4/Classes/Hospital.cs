using System;

namespace Lab4.Classes
{
    abstract class Hospital
    {
        public abstract void HospitalDetails();
    }
    class Apollo:Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is from Apollo");
        }
    }
    class Wockhardt:Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is from Wockhardt");
        }
    }
    class Gokul_Superspeciality:Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is from Gokul_Superspeciality");
        }
    }
}
