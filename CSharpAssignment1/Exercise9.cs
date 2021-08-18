using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise9
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i;
            
            Console.Write(n1 + " " + n2 + " ");    
            for (i = 3; i <=40; ++i)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
