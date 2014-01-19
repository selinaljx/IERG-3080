using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class SavingAccount : Account
    {
        //constructor
        public SavingAccount(string id, double balance) : base(id,balance) {}

       public string ID { get; private set; }
       public double Balance { get; private set; }

       public void Deposit(double amount) 
        {
            this.Balance = amount;
        }

        public void Transfer(Assignment_2.CurrentAccount currentAccount, double trans) 
        {
            this.Balance -= trans;
            currentAccount.Deposit(trans);
        }

        public override void PrintBalance()
        {
            base.PrintBalance();
        }
    }
}
