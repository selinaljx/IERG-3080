using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class SavingAccount : Account
    {
        public string ID { get; private set; }
        public double Balance { get; private set; }
        public string Type { get; private set; }


        public SavingAccount(string id, string balance, string type) : base (id, balance, type)
        { }

        public override void Report()
        {
            base.Report();
        }

       
    }
}
