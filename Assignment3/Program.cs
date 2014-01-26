using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyReader reader = new MyReader();
            List<Account> list = reader.ImportAccount("Assignment4.csv");

            foreach(Account acc in list)
            {
                acc.Report();
            }

            Console.ReadLine();
        }
    }
}
