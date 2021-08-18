using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpassignment1
{
    class Exercise16
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a word:");
            string str = Console.ReadLine();
            string str2 = new string(str.Reverse().ToArray());
            Console.WriteLine(str2);
        }
    }
}
