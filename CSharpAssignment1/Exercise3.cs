using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise3
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("Enter 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
