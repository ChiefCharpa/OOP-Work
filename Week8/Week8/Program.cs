using System;
using System.Collections.Generic;
using System.Linq;
using Week8;

namespace CMP1903M_Workshops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 8
            //Challenge: Get a Luber to find your friends for the night out..!
            //

            //Week 8
            // Bank Accounts
            List<IAccount> acc = new List<IAccount>();
            acc.Add(new BasicAccount(012345, "aaaa", 0));
            acc.Add(new BasicAccount(012346, "bbbb", 10));
            acc.Add(new BasicAccount(012347, "cccc", 125));
            acc.Add(new BasicAccount(012348, "dddd", 0));
            acc.Add(new BasicAccount(012349, "eeee", 10));

            acc.Add(new PremiumAccount(123450, "ffff", 0, 0));
            acc.Add(new PremiumAccount(123451, "gggg", 100, 100));
            acc.Add(new PremiumAccount(123452, "hhhh", 125, 50));
            acc.Add(new PremiumAccount(123453, "iiii", 0, 0));

            var list = from account in acc where account.BasicAccount == basicAccount select account;
        }
    }
}
