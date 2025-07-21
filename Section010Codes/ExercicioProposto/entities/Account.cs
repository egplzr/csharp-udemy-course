using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section010Codes.ExercicioProposto.entities.exception;

namespace Section010Codes.ExercicioProposto.entities
{
    public class Account(int number, string holder, double balance, double withdrawLimit)
    {
        public int Number { get; set; } = number;
        public string Holder { get; set; } = holder;
        public double Balance { get; set; } = balance;
        public double WithdrawLimit { get; set; } = withdrawLimit;

        public void Deposit(double amout)
        {
            Balance += amout;
        }

        public void Withdraw(double amout)
        {
            if (amout > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (amout > Balance)
            {
                throw new DomainException("The amount exceeds your account balance");
            }
            else
            {
                Balance -= amout;
            }
        }
    }
}