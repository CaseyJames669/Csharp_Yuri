using System;

namespace BladowCasey_ex12_13
{
    public class Account : IAccount
    {
        private decimal balance = 0;

        public decimal Balance
        {
            get 
                {
                    return balance;
                }
            set
                {
                    if (value < 0)
                    {
                        throw new AccountException("Initial balance was invalid");
                    }
                    else
                    {
                        balance = value;
                    }
                }
        }

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public virtual void Credit(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual bool Debit(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
            {
                this.Balance -= amount;
                return true;
            }
        }
    }
    
    public interface IAccount
    {
        decimal Balance { get; set; }

        void Credit(decimal creditAmount);

        bool Debit(decimal debitAmount);
    }
}
