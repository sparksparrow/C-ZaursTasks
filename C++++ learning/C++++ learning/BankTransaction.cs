using System;

namespace C_____learning
{
    class BankTransaction
    {
        readonly DateTime date;
        readonly int sum;        
        public DateTime Datetime
        {
            get{ return this.date;}           
        }
        public int Sum
        {
            get { return this.sum; }
        }
        public BankTransaction(int sum1)
        {
            this.date = DateTime.Now;
            this.sum = sum1;
        }
    }
}
