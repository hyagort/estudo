using Estudo.Entities;
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcast

            Account acc1 = bacc;
            Account acc2 = new SavingsAccounts(1004, "Anna", 0.0, 0.01);

            //Downcast

            BusinessAccount acc3 = (BusinessAccount)acc1;
            acc3.Loan(100.0);

            if (acc2 is BusinessAccount)
            {
                BusinessAccount acc4 = (BusinessAccount)acc2;
            }
            else if (acc2 is SavingsAccounts)
            {
                SavingsAccounts acc4 = (SavingsAccounts)acc2;
                acc4.UpdateBalance();
                Console.WriteLine("Update!");
            }


            Console.WriteLine(account.Balance);


        }
    }
}
