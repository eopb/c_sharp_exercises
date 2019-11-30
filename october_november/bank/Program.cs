using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Current currentAccount = new Current();
            currentAccount.print();
        }
    }
}
