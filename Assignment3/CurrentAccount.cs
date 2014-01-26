using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class CurrentAccount : Account
    {
        public string Region { get; private set; }
        public string Branch { get; private set; }
        public string ID { get; private set; }
        public string Balance { get; private set; }

        public CurrentAccount(string region, string branch, string id, string balance) : base (region, branch, id, balance)
        { }

        public override void Report()
        {
            Console.Write("Current account");
            base.Report();
        }
    }
}
