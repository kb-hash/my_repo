using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise10
    {
        public static void Main()
        {
            int j, n;

            

            Console.Write("Input the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (j = 1; j <= 20; j++)
            {
                Console.WriteLine("{0} X {1} = {2} ", n, j, n * j);
            }
        }
    }
}