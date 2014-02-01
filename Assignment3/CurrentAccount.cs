using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class CurrentAccount : Account
    {
        public string ID { get; private set; }
        public double Balance { get; private set; }
        public string Type { get; private set; }
        public CurrentAccount(string id, string balance, string type) : base (id, balance, type)
        {}

        public override void Report()
        {
            base.Report();
        }

        internal double Deposit(double amount, double balance)
        {
            return balance += amount;
        }
    }
}
