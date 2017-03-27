
namespace BladowCasey_ex12_13
{
    public class CheckingAccount : Account
    {
        private decimal Fee { get; set; }

        public CheckingAccount(decimal balance, decimal fee):base(balance)
        {
            Fee = fee;
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            this.Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                this.Balance -= Fee;
                return true;
            }

            return false;
        }
    }
}
