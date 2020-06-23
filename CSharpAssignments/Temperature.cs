using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Temperature
    {
        public static void Main()
        {
            double celcius, farenheit;
            Console.WriteLine("Enter the temperature in Celcius");
            celcius = Convert.ToDouble(Console.ReadLine());
            farenheit = (celcius * 9 )/ 5 + 32;
            Console.WriteLine(celcius + "C in Farenheit is " + farenheit + "F");
            Console.ReadKey();
        }
    }
}
