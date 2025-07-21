using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExemploAula.Entities
{
    sealed class SavingsAccount(int number, string holder, double balance, double interestRate)
    : Account(number, holder, balance)
    {
        public double InterestRate { get; set; } = interestRate;

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}