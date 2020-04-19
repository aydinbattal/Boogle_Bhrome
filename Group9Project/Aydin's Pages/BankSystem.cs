using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9Project.Aydin_s_Pages
{
    class BankSystem
    {
        public double Balance { get; protected set; }
        public double OverdraftAmount { get; set; }
        public string User { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public BankSystem()
        {
            Balance = 100;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Not enough money");

            if (Balance + OverdraftAmount < 0)
                throw new Exception();


            Balance -= amount;

            if (Balance <= 0)
            {
                Balance -= 100;
            }

        }

        public void UpdateBalance(double balance)
        {
            Balance = balance;
        }
    }
}
