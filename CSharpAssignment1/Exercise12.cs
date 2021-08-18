using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise12
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.Write("Enter first Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third Number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
    }

