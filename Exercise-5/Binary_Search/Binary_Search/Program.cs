using System;
using System.Collections;

namespace Binary_Search
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int low, mid, high;

				Console.WriteLine("\t\t\tBINARY SEARCH");
				Console.WriteLine("\t\t\t-------------");
				Console.Write("Enter the size of an array:");
				int n = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the array elements:");
				int[] arr = new int[n];
				for (int i=0; i<n; i++)
				{
					arr [i] = Convert.ToInt32 (Console.ReadLine());
				}
				Array.Sort(arr); 			 
				Console.Write("Enter the item to be searched:");
				int item = Convert.ToInt32 (Console.ReadLine());
				Console.WriteLine("The sorted array is:");
				foreach(int i in arr)
				{
					Console.WriteLine(i);
				}
				low = 0;
				high = (n - 1);
				while (low <= high)
			    {
					mid = (low + high) / 2;
					if (item < arr [mid])
						high = mid - 1;
					else if (item > arr [mid])
						low = mid + 1;
					else if (item == arr [mid]) {
						Console.WriteLine ("Element {0} found at location {1}", item, mid );
					
						break;
					}
				}
				if(low>high)
				{
					Console.WriteLine ("Element is not found in the array");
				}
		}
	}
}
