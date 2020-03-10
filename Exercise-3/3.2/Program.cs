using System;
using System.Collections.Generic;
namespace lambda
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> l1 = new List<int> ();
			l1.Add (100);
			l1.Add (200);
			l1.Add (300);
			Console.WriteLine ("Search the collections using lambda:");
			Console.WriteLine ("------------------------------------");
			int value = l1.Find (m=>m.Equals(200));
			Console.WriteLine (value);
		}
	}
}
