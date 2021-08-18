using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Exercise13
    {
		public static void Main()
		{
			
			int[] arr = new int[5];

			//to input elements of array
			for (int i = 0; i < 5; i++)
			{
				Console.Write("Enter value for a[{0}]: ",i);
				arr[i] = int.Parse(Console.ReadLine());
			}

		//to find smallest value
			int smallest = arr[0];

			for (int i = 1; i < 5; i++)
			{
				if (arr[i] < smallest)
				{
					smallest = arr[i];
				}
			}

			
			Console.WriteLine("Smallest value is: " + smallest);
		}
	}

}

