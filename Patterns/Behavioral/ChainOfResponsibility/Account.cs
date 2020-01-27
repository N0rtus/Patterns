using System;

namespace ChainOfResponsibility
{
    public class Account
    {
        private Account _alternative;

        public long Value;
        
        public void SetNext(Account alternative)
        {
            _alternative = alternative;
        }

        public void Pay(long price)
        {
            if (CanPay(price))
            {
                Console.WriteLine($"Paid {price:#,0} using {this.GetType().Name}");   
            }
            else if (_alternative != null)
            {
                Console.WriteLine($"Can't paid {price:#,0} using {this.GetType().Name}");
                _alternative.Pay(price);
            }
            else
            {
                throw new InvalidOperationException("Hasn't credit.");
            }
        }

        private bool CanPay(long price)
        {
            return Value >= price;
        }
    }
}