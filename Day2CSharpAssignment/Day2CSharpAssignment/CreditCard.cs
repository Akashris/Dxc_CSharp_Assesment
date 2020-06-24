using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpAssignment
{
    class CreditCard
    {
        private int months;
        private double totalAmount;
        private double balance;
        private double monthlyPayment;
        private double interest;

        public CreditCard() { /*Default Constructor*/ }

        public double Interest { get => interest; set => interest = value; }
        public double MonthlyPayment { get => monthlyPayment; set => monthlyPayment = value; }
        public double Balance { get => balance; set => balance = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public int Months { get => months; set => months = value; }

        public void Payment()
        {
            for(int loopIndex = Months ; TotalAmount >= 0; loopIndex++)
            {
                TotalAmount = Balance + (Balance * interest) / 100;
                TotalAmount -= MonthlyPayment;
                Balance = TotalAmount;
                Console.WriteLine("Month: " + loopIndex + " balance: " + TotalAmount + "total payments: " + loopIndex * MonthlyPayment);

            }
        }
    }
}
