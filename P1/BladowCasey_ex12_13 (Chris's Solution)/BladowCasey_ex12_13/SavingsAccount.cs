
namespace BladowCasey_ex12_13
{
    public class SavingsAccount : Account
    {
        private decimal InterestRate { get; set; }

        public SavingsAccount(decimal balance, decimal rate): base(balance)
        {
            this.InterestRate = rate;
        }
            
        public decimal CalculateInterest()
        {
            return this.InterestRate * this.Balance;
        }
    }
}
