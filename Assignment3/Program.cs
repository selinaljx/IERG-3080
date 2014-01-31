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
            Dictionary<string, List<Account>> regionList = reader.ImportAccount("Assignment4.csv");
            

            foreach(string region in regionList.Keys)
            {
                List<Account> accountList = regionList[region];
                foreach (Account acc in accountList)
                {
                    acc.Report();
                }
            }

            

            Console.ReadLine();


            Transaction transaction = new Transaction();
            transaction.Process(regionList);

            foreach(string region in regionList.Keys)
            {
                List<Account> accountList = regionList[region];
                foreach (Account acc in accountList)
                {
                    acc.Report();
                }
            }

                Console.ReadLine();

        }
    }
}
