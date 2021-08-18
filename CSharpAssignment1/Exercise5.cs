using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise5
    {
        static void Main()
        {
            int[] arr = new int[100];
            int i, num, evennum, oddnum;

            ////Reads size and elements in array
            Console.WriteLine("Enter count of numbers: ");
            num = Convert.ToInt32(Console.ReadLine());
            

            for (i = 0; i < num; i++)
            {
                Console.Write("Enter number {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; // Assuming 0 even numbers
            oddnum = 0; // Assuming 0 odd numbers

            for (i = 0; i < num; i++)
            {
                /* If the current element of array is evennumber then increment evennumber count */
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; // increment oddnumber count
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);


            Console.ReadLine();
        }
    }
}
