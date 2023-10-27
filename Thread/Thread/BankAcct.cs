using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadByme
{
    class BankAcct
    {
        private Object acctLock=new Object();
        double Balance { get;set;}
        string Name {  get; set; }

        public BankAcct(double balance)
        {
            Balance = balance;
        }
        public double Withdraw(double amt)
        {
            if((Balance-amt) < 0)
            {
                Console.WriteLine("Insufficient BAlance");
                return Balance;
            }
            lock (acctLock)
            {
                if(Balance >= amt)
                {
                    Console.WriteLine("Removed {0}  and {1} left in account", amt, (Balance - amt));
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}
