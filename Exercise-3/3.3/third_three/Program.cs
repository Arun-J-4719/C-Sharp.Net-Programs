using System;
using System.Collections.Generic;
namespace third_three
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var events = numbers.FindAll (n => n % 2 == 0);
			Console.WriteLine ("The Even Numbeas Are");
			foreach (int a in events) {
				Console.WriteLine (a);
			}

		}
	}
}
