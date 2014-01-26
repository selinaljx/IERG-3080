using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment_3
{
    class MyReader
    {

        public List<Account> ImportAccount(string filename)
        {
            //read the .csv file
            var reader = new StreamReader(File.OpenRead(filename));
            List<Account> list = new List<Account>();

            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var values = line.Split(',');

                foreach (var v in values)
                {
                    if (v == "Saving")
                    {
                        list.Add(new SavingAccount(values[0], values[1], values[2], values[4]));
                    }
                    else if (v == "Current")
                    {
                        list.Add(new CurrentAccount(values[0], values[1], values[2], values[4]));
                    }
                }
            }

            return list;
        }
    }
}
