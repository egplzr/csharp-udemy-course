namespace Section009Codes.ExemploAula.Entities
{
    public class BusinessAccount(int number, string holder, double balance, double loanLimit) : Account(number, holder, balance)
    {
        public double LoanLimit { get; set; } = loanLimit;

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}