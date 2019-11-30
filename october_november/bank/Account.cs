using System;

namespace bank
{
    class Account
    {
        public double balance;
        public Account()
        {
            balance = 1;
        }
        public virtual void print()
        {
            System.Console.WriteLine(balance);
        }
    }
    class Current : Account
    {
        public Current()
        {
            balance = 1;
        }
        public override void print()
        {
            System.Console.WriteLine(balance);
        }
    }
}
