using CMP1903M_Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    internal class PremiumAccount : IAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public decimal Overdraft { get; set; }

        //Constructor setting default balance of 0
        public PremiumAccount()
        {
            Balance = 0.0M;
            AccountNumber = 0;
            AccountName = "default";
            Overdraft = 0.0M;
        }

        //constructor setting balance to value
        public PremiumAccount(int accNumber, string AccName, decimal value, decimal value2)
        {
            Balance = value;
            AccountName = AccName;
            AccountNumber = accNumber;
            Overdraft = value2;
        }

        //Deposit method
        public bool Deposit(decimal value)
        {
            Balance += value;
            return true;
        }

        public bool Withdraw(decimal value)
        {
            if (Balance + Overdraft >= value)
            {
                //withdraw ok
                Balance -= value;
                return true;
            }
            else
            {
                //Withdraw too much for balance
                return false;
            }
        }
    }
}
