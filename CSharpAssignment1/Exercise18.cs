using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpassignment1
{
    class Exercise18
    {
        public static void Main()
        {
            Console.Write("Enter 1st word:");
            string str1 = Console.ReadLine();
            string str2 = new string(str1.Reverse().ToArray());
            if (str2.Equals(str1))
            {
                Console.WriteLine("Entered word is a palindrome");

            }
            else
                Console.WriteLine("Entered word is not a palindrome");
        }
    }
}
