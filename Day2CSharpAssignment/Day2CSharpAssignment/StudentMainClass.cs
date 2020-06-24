using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpAssignment
{
    class StudentMainClass
    {
        public static void Main()
        {
            Student s1 = new Student()
            {
                RollNo = 2015010,
                StudName = "Akash",
                MarksEng = 90,
                MarksMath = 98,
                MarksScience = 95
            };
            s1.CalculatePercentage();
            s1.Display();
            Console.ReadKey();
        }
    }
}
