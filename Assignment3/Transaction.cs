using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment_3
{
    class Transaction
    {
        internal void Process(Dictionary<string, List<Account>> regionList)
        {
            var file = new StreamReader(File.OpenRead("transactions.csv"));
            SavingAccount savingAccount = new SavingAccount("", "0", "");
            CurrentAccount currentAccount = new CurrentAccount("", "0", "");

            var i = 0;
            while (!file.EndOfStream)
            {
                var line = file.ReadLine();

                if (i > 0)
                {

                    var values = line.Split(',');
                    var transaction = values[0];
                    var amount = double.Parse(values[1]);
                    var id = values[2] + '-' + values[3] + '-' + values[4];
                    var type = values[5];
                    var toID = values[6] + '-' + values[7] + '-' + values[8];
                    var toType = values[9];

                    List<Account> accountList = regionList[values[2]];
                    //TO DO
                    //1. identify the ID from Account list
                    //2. find the type of account 
                    //3. find the type of transaction


                    switch (transaction)
                    {
                        case "Withdraw":

                            foreach (Account acc in accountList)
                            {
                                if (acc.ID == id && acc.Type == type)
                                   acc.Balance = savingAccount.Withdraw(amount, acc.Balance);
                            }
                            break;
                        case "Deposit":

                            foreach (Account acc in accountList)
                            {
                                if (acc.ID == id && acc.Type == type)
                                    acc.Balance = savingAccount.Deposit(amount, acc.Balance);
                            }
                            break;

                        case "Transfer":
                            double save = 0, current = 0;
                            foreach (Account acc in accountList)
                            {
                                if (acc.ID == id)
                                {
                                    if (acc.Type == type)
                                        save = acc.Balance;
                                    if (acc.Type == toType)
                                        current = acc.Balance;
                                }

                                //return an array of double
                                double[] trans = savingAccount.Transfer(currentAccount, amount, save, current);

                                if (acc.ID == id)
                                {
                                    if (acc.Type == type)
                                        acc.Balance = trans[0];
                                    if (acc.Type == toType)
                                        acc.Balance = trans[1];
                                }
                            }
                            break;
                    }


                }
                i++;
            }


        }
    }
}
