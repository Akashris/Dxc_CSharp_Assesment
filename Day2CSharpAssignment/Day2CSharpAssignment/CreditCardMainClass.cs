using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpAssignment
{
    class CreditCardMainClass
    {
        static void Main(string[] args)
        {
            CreditCard c1 = new CreditCard
            {
                Interest = 1.5,
                Balance = 915.0,
                Months = 1
            };

            Console.Write("Enter The Monthly Payment : ");
            c1.MonthlyPayment = Convert.ToDouble(Console.ReadLine());
            c1.TotalAmount = c1.Balance;
            c1.Payment();
            Console.ReadKey();
        }
    }
}
