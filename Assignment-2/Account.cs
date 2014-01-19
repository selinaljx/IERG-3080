using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class Account
    {
        public Account(string id, double balance)
        {
            this.ID = id;
            this.Balance = balance;
        }

        public string ID { get; private set; }
        public double Balance { get; private set; }

        public virtual void PrintBalance()
        {
            Console.WriteLine("The balance of saving account ID = {0} is {1}", ID ,Balance);
        }
    }
}
