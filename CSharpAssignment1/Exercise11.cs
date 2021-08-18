using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise11
    {
        static void Main()
        {
            for (int j = 200; j < 300; j++)
            {
                if ( j % 7 == 0)
                    Console.Write(j + " ");
            }
        }
    }
}
