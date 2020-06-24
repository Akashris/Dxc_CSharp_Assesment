using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpAssignment
{
    class BookStoreMainClass
    {
        public static void Main()
        {
            BookStore b1 = new BookStore
            {
                Isbn = 1234,
                BookName = "Wings Of Fire",
                BookTitle = "Motivation",
                BookAuthor = "A.P.J.Abdul kalam",
                QuantityOfBooks = 4,
                BookPrice = 400.0,

            };
            b1.TotalPrice = b1.CalculatePrice();
            b1.DisplayDetails();
            b1.BillingDetails();
            Console.ReadKey();
        }
    }
}
