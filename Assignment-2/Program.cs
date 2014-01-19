using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //new savingAccount object
            SavingAccount savingAccount = new SavingAccount("",0);
            savingAccount.Deposit(100);
            Console.WriteLine("Saving account balance = {0}", savingAccount.Balance);

            //new currentAccount object
            CurrentAccount currentAccount = new CurrentAccount("",0);
            Console.WriteLine("Current account balance = {0}", currentAccount.Balance);

            savingAccount.Transfer(currentAccount, 20);  //???
            Console.WriteLine("Saving account balance = {0}", savingAccount.Balance);
            Console.WriteLine("Current account balance = {0}", currentAccount.Balance);

            Console.WriteLine();

            //new account object in a container
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingAccount("Apple", 100));
            accounts.Add(new CurrentAccount("Orange", 200));

            foreach(Account account in accounts)
            {
                account.PrintBalance();
            }


            Console.ReadLine();
        }
    }
}
