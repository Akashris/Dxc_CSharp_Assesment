using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpAssignment
{
    class AreaMainClass
    {
        static void Main()
        {
            Area area = new Area();
            area.CalculateArea(6.1f);
            area.CalculateArea(10, 22);
            area.CalculateArea(5.1);
            Console.ReadKey();
        }
    }
}
