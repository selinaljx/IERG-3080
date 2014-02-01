using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class SavingAccount : Account
    {
        private Tuple<double, double> Tuple;
        public string ID { get; private set; }
        public double Balance { get; private set; }
        public string Type { get; private set; }


        public SavingAccount(string id, string balance, string type) : base (id, balance, type)
        { }

        public override void Report()
        {
            base.Report();
        }
        public double Withdraw(double amount, double balance)
        {
            return balance -= amount;
        }

        public double Deposit(double amount, double balance)
        {
            return balance += amount;
        }

        public double[] Transfer(Assignment_3.CurrentAccount currentAccount, double amount, double save, double current)
        {
           // save -= amount;
           // current = currentAccount.Deposit(amount, current);

            double[] trans;
            trans = new double[2];

            trans[0] = save - amount;
            trans[1] = currentAccount.Deposit(amount, current);

            return trans;
             
        }
    }
}
