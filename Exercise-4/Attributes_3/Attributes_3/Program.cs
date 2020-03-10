using System;

namespace Attributes_3
{
	class MainClass
	{
		[Obsolete("Stupid! Call next method")]
		public static void daysomething(String str)
		{
			Console.WriteLine (str);
		}

		public static void table(String str)
		{
			Console.WriteLine (str);
		}

		public static void Main (string[] args)
		{
			daysomething ("Hello Everyone!");
			Console.ReadLine ();
		}
	}
}
