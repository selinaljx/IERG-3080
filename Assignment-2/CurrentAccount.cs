using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class CurrentAccount : Account
    {
        //constructor
        public CurrentAccount(string id, double balance) : base(id, balance) { }
        public string ID { get; private set; }
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            this.Balance = amount;
        }

        public override void PrintBalance()
        {
            base.PrintBalance();
        }
    }
}
