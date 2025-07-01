using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Classes
{
    public class Account_Details
    {
        string AccountNumber;
        string AccountHolderName;
        double Principal;
        double Rate;
        int Time;

        public void GetAccountInfo()
        {
            Console.Write("Enter Account Number: ");
            AccountNumber = Console.ReadLine();

            Console.Write("Enter Account Holder Name: ");
            AccountHolderName = Console.ReadLine();

            Console.Write("Enter Principal Amount: ");
            Principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest (%): ");
            Rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            Time = Convert.ToInt32(Console.ReadLine());
        }
    }

}
