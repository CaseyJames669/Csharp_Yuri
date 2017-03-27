using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex_10_05
{
    public class SavingAccount : ISavingAccount
    {
        // interest rate for all accounts
        private static decimal annualInterestRate = 0M;

        private decimal savingsBalance; // balance for current account

        public SavingAccount(decimal balance)
        {
            if(balance >= 0M)
                savingsBalance = balance;
        }
        public void CalculateMonthlyInterest()
        {
            //throw new NotImplementedException();
            savingsBalance += savingsBalance * (annualInterestRate / 12M);
        }
        // Modify the interest rate
        public static void ModifyInterestRate(decimal newRate)
        {
            if (newRate >= 0M && newRate <= 1M)
                annualInterestRate = newRate;
            else
                throw new ArgumentOutOfRangeException("annualInterestRate", newRate, 
                    "interest rate must be between 0 and 1");
        }

        // Get string representation of SavingAccount object
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0:c}", savingsBalance);
        }
    }
}
