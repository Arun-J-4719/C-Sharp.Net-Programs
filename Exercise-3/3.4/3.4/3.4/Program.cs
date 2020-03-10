using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] digits = { "zero","one","two","three","four","five","six","seven","eight","nine"};
			var sd1=digits.where((digits.index) => digits.length<index);
			foreach(var sd in sd1)
			{
				Console.WriteLine(sd);

			}
			List<string> sd2=new List<string>();
			for(var  i=0;i<digits.length;i++)
			{
				if(digits[i].length<i)
					sd2.Add(digits[i]);

			}

			foreach(var d in sd2)
			{
				Console.WriteLine(d);
			}



		}
	}
}
