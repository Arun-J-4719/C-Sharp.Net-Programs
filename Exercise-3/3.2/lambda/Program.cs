using System;
using System.Collections.Generic;
namespace lambda
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n, value;
			List<int> l1 = new List<int> ();
			l1.Add (100);
			l1.Add (200);
			l1.Add (300);
			Console.WriteLine ("\t\t Searching the Collections using Lambda:-");
			Console.WriteLine ("\t\t --------- --- ----------- ----- --------");
			Console.Write ("Enter Number to Search:");
			n = Convert.ToInt16 (Console.ReadLine()); 
			value = l1.Find (m=>m.Equals(n));
			Console.WriteLine(value);
		}
	}
}
