using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpassignment1
{
    class Exercise17
    {
        public static void Main()
        {
            Console.Write("Enter 1st word:");
            string str1 = Console.ReadLine();

            Console.Write("Enter 2nd word:");
            string str2 = Console.ReadLine();
            if (str1.Equals(str2))
            {
                Console.WriteLine("Both words are same");

            }
            else
                Console.WriteLine("Both words are different");

        }
    }
}
