using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class Account
    {
        public string ID { get; private set; }
        public double Balance { get; set; }
        public string Type { get; private set; }

        public Account(string id, string balance, string type)
        {
            this.ID = id;
            this.Balance = Double.Parse(balance);
            this.Type = type;
        }

        public virtual void Report()
        {
            //print the read file content
            Console.WriteLine(" {0} balance = {1}",this.ID, this.Balance);
        }

        
    }
}
