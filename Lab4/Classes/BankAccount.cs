using System;

namespace Lab4.Classes
{
    class BankAccount
    {
        double initialBalance;
        string accountHolderName;

        public BankAccount(double initialBalance, string accountHolderName)
        {
            this.initialBalance = initialBalance;
            this.accountHolderName = accountHolderName;
        }
        public void Deposit(double cash)
        {
            if (cash > 0)
            {
                initialBalance+=cash;
                Console.WriteLine("Deposit successful. New balance: " + initialBalance);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Deposit(String checkNumber, double amount)
        {
            if(amount > 0)
            {
                initialBalance += amount;
                Console.WriteLine("Check deposit successful. Check Number: " + checkNumber + ", New balance: " + initialBalance);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double cash)
        {
            if (cash>0 && cash <= initialBalance)
            {
                initialBalance -= cash;
                Console.WriteLine("Withdrawn cash: " + cash);
            }
            else
            {
                Console.WriteLine("Invalid cash withdrawl amount");
            }
        }
        public void Withdraw(String checkNumber, double amount)
        {
            if (amount > 0 && amount <= initialBalance)
            {
                initialBalance -= amount;
                Console.WriteLine("Withdrawn using check (No: " + checkNumber + "):" + amount);
            }
            else
            {
                Console.WriteLine("Invalid cash withdrawl amount");
            }
        }
    }
}
