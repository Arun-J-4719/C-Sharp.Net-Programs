using System;
using System.Collections.Generic;
using System.Linq;

namespace IENumerable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int max = 0;
			int[] arr = new int[5];
			Console.WriteLine("Enter Array Elements:");
			for (int i = 0; i < 5; i++) 
			{
				arr[i] = Convert.ToInt32 (Console.ReadLine());
			}

			IEnumerable<int> ienum = from a in arr orderby a select a;
			Console.WriteLine("The Arrray is:");
			foreach(int i in ienum)	
			{
				max=i;
				Console.WriteLine(i);
			}
			Console.WriteLine("The Largest Number: "+max);
		}
	}
}
