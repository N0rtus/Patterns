using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var price = 299;
            
            var bank = new Bank();
            var payPal = new Paypal();
            var bitcoin = new Bitcoin();
            
            bank.SetNext(payPal);
            
            payPal.SetNext(bitcoin);
            
            bank.Pay(price);

            Console.ReadKey();
        }
    }
}