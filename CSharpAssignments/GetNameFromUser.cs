using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class GetNameFromUser
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();

            Console.WriteLine("Hi !! " + name);
            Console.WriteLine("welcome To The World of C#");
            Console.ReadKey();
        }
    }
}
