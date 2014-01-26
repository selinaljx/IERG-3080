using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class Account
    {
        public string Region { get; private set; }
        public string Branch { get; private set; }
        public string ID { get; private set; }
        public string Balance { get; private set; }

        public Account(string region, string branch, string id, string balance)
        {
            this.Region = region;
            this.Branch = branch;
            this.ID = id;
            this.Balance = balance;
        }

        public virtual void Report()
        {
            //print the read file content
            Console.WriteLine(" {0}-{1}-{2} balance={3}",this.Region, this.Branch, this.ID, this.Balance);

        }
    }
}
