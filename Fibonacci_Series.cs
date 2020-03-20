using System;
namespace Fibonacci
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n, f1=0, f2=1, f3=0,i;
			Console.Write("Enter the Range:");
			n = Convert.ToInt32(Console.ReadLine ());
			if (n < 0) 
			{
				Console.WriteLine ("Enter the Valid Input...");
			}
			else
			{
				Console.WriteLine ("The Fibonacci Series are:");
				Console.WriteLine (f1);
				Console.WriteLine (f2);
				for(i=2;i<n;i++)
				{
					f3 = f1 + f2;
					f1 = f2;
					f2 = f3;
					Console.WriteLine (f3);
				}
			}
		}
	}
}
