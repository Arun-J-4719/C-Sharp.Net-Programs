using System;

namespace Pascal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n,i,j;
			int[,] arr = new int[8, 8];
			Console.Write ("Enter the Range:");
			n = Convert.ToInt32 (Console.ReadLine());
			if (n > 0) 
			{
				Console.WriteLine("Pascal Triangle : ");
				for (i = 0; i <= n; i++)
				{
					for (int k = n; k > i; k--)
					{   
						Console.Write(" ");
					}
					for (j = 0; j < i; j++)
					{
						if (j == 0 || i == j)
						{
							arr[i, j] = 1;
						}
						else
						{
							arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
						}
						Console.Write(arr[i, j] + " ");
					}
					Console.WriteLine ();
				}
			}
			else
			{
				Console.WriteLine ("Enter the Valid Input...");
			}
		}
	}
}
