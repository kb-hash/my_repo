using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpassignment1
{
	class Exercise14
	{
		public static void Main()
		{

			int[] arr = new int[10];

			//to input elements of array
			for (int i = 0; i < 10; i++)
			{
				Console.Write("Enter Mark {0}: ", i);
				arr[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Average Marks:{0}", arr.Average());
			Console.WriteLine("Total Marks:{0}", arr.Sum());
			Console.WriteLine("Maximum Mark:{0}", arr.Max());
			Console.WriteLine("Minimum Mark:{0}", arr.Min());
			Array.Sort(arr);
			foreach(int i in arr)
            {
				Console.Write(i + " ");
            }



		}
	}
}
