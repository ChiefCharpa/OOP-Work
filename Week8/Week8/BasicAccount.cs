using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    class BasicAccount : IAccount
    {

        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        //Constructor setting default balance of 0
        public BasicAccount()
        {
            Balance = 0.0M;
            AccountNumber = 0;
            AccountName = "default";
        }

        //constructor setting balance to value
        public BasicAccount(int accNumber, string AccName, decimal value)
        {
            Balance = value;
            AccountName = AccName;
            AccountNumber = accNumber;
        }

        //Deposit method
        public bool Deposit(decimal value)
        {
            Balance += value;
            return true;
        }

        public bool Withdraw(decimal value)
        {
            if (Balance >= value)
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
