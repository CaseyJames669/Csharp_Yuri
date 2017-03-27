using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BladowCasey_ex12_13;

namespace ClientConsole
{
    public class AccountPolyClass
    {
        public static void AccountPoly(IAccount[] accounts)
        {
            // loop through array, prompting user for debit and credit amounts
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine("Account {0} balance: {1:C}",
                   i + 1, accounts[i].Balance);

                Console.Write(
                   "\nEnter an amount to withdraw from Account {0}: ", i + 1);
                decimal withdrawalAmount =
                   Convert.ToDecimal(Console.ReadLine());

                accounts[i].Debit(withdrawalAmount); // attempt to debit

                Console.Write(
                   "\nEnter an amount to deposit into Account {0}: ", i + 1);
                decimal depositAmount =
                   Convert.ToDecimal(Console.ReadLine());

                // credit amount to Account
                accounts[i].Credit(depositAmount);

                // if Account is a SavingsAccount, calculate and add interest
                if (accounts[i] is SavingsAccount)
                {
                    // downcast
                    SavingsAccount currentAccount =
                       (SavingsAccount)accounts[i];

                    decimal interestEarned = currentAccount.CalculateInterest();
                    Console.WriteLine(
                       "Adding {0:C} interest to Account {1} (a SavingsAccount)",
                       interestEarned, i + 1);
                    currentAccount.Credit(interestEarned);
                } // end if

                Console.WriteLine("\nUpdated Account {0} balance: {1:C}\n\n",
                   i + 1, accounts[i].Balance);
            } // end for

            Console.Read();
        }
    }
}
