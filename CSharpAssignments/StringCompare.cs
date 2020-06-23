using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class StringCompare
    {
        public static void Main()
        {
            string str1, str2;
            int flag = 1;
            Console.WriteLine("Enter The Two Strings");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            str1 = str1.Trim();
            str2 = str2.Trim();
            if (str1.Length == str2.Length)
            {
                flag = string.Compare(str1, str2);
                if(flag==0)
                {
                    Console.WriteLine("Strings Are Equal");
                }
            }
            else
            {
                Console.WriteLine("Strings Are Not Equal");
            }
            Console.ReadKey();
        }
    }
}
