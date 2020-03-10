using System;
using System.Collections.Generic;
using System.Linq;

namespace VarClass
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int min = 0;
			Console.WriteLine ("Enter the size of an array:");
			int n = Convert.ToInt32 (Console.ReadLine ());
			int[] arr = new int[n];
			Console.WriteLine ("Enter your number:");
			for (int i = 0; i < n; i++)
			{
				arr [i] = Convert.ToInt32 (Console.ReadLine ());
			}

			var mylist = from a in arr orderby a select a;
			Console.WriteLine ("The List is ");
			foreach (int i in mylist.Reverse()) 
			{
				min = i;
				Console.WriteLine(i);
			}
			Console.WriteLine ("The Smallest number is: "+min);
		}
	}
}
