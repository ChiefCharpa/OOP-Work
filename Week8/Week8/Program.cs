using System;
using System.Collections.Generic;
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
            List<BasicAccount> basicAccount = new List<BasicAccount> ();
            basicAccount.Add(new BasicAccount(012345, "aaaa", 0));
            basicAccount.Add(new BasicAccount(012346, "bbbb", 10));
            basicAccount.Add(new BasicAccount(012347, "cccc", 125));
            basicAccount.Add(new BasicAccount(012348, "dddd", 0));
            basicAccount.Add(new BasicAccount(012349, "eeee", 10));

            List<PremiumAccount> premiumAccount = new List<PremiumAccount> ();
            premiumAccount.Add(new PremiumAccount(123450, "ffff", 0, 0));
            premiumAccount.Add(new PremiumAccount(123451, "gggg", 100, 100));
            premiumAccount.Add(new PremiumAccount(123452, "hhhh", 125, 50));
            premiumAccount.Add(new PremiumAccount(123453, "iiii", 0, 0));


        }
    }
}
