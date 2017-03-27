using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BladowCasey_ex12_13;

namespace ClientConsole
{
    public class AccountTest
    {
        public static void Main(string[] args)
        {
            // create array of accounts
            IAccount[] accounts = new IAccount[4];

            // initialize array with Accounts
            accounts[0] = new SavingsAccount(25M, .03M);
            accounts[1] = new CheckingAccount(80M, 1M);
            accounts[2] = new SavingsAccount(200M, .015M);
            accounts[3] = new CheckingAccount(400M, .5M);

            AccountPolyClass.AccountPoly(accounts);

        } // end Main
    }
}
