using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExemploAula.Entities
{
    public abstract class Account(int number, string holder, double balance)
    {
        public int Number { get; protected set; } = number;
        public string Holder { get; protected set; } = holder;
        public double Balance { get; protected set; } = balance;

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}