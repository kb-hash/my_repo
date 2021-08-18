using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise4
    {
        static void Main()
        {
            int i;
            Console.Write("Enter a Number:");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("{0} is even", i);
            }
            else
                Console.WriteLine("{0} is odd",i);
        }
    }
}
