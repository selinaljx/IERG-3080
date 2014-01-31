using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;  //to use the class of StreamReader

namespace Assignment_3
{
    class MyReader
    {

        public Dictionary<string, List<Account>> ImportAccount(string filename)
        {
            //read the .csv file
            var reader = new StreamReader(File.OpenRead(filename));
            Dictionary<string, List<Account>> regionList = new Dictionary<string, List<Account>>();

            
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var values = line.Split(',');
                
                string region = values[0];
                
                // check if there is different region code
                if (!regionList.ContainsKey(region))
                {
                    regionList.Add(region, new List<Account>());
                }

                List<Account> accountList = regionList[values[0]];

                foreach (var v in values)
                {
                    if (v == "Saving" && values[0] != "Region")
                    {
                        accountList.Add(new SavingAccount(values[0]+'-'+values[1]+'-'+values[2], values[4], "Saving"));
                    }
                    else if (v == "Current" && values[0] != "Region")
                    {
                        accountList.Add(new CurrentAccount(values[0]+'-'+values[1]+'-'+values[2], values[4], "Current"));
                    }
                }

                
            }

            return regionList;
        }
    }
}
