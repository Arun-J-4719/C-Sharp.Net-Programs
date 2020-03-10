using System;
using System.Reflection;

namespace Attributes_1
{
	[AttributeUsage(AttributeTargets.Class|
	                AttributeTargets.Constructor|
	                AttributeTargets.Field|
	                AttributeTargets.Property,
	                AllowMultiple=true)]

	public class Help_Attribute:System.Attribute
	{
		private int regno;
		private String comment;

		public Help_Attribute(int regno)
		{
			this.regno = regno;
		}

		public int regno_1
		{
			get
			{
				return regno;
			}
		}

		public String comment_1
		{
			get 
			{
				return comment;
			}
			set 
			{
				comment = value;
			}
		}
	}
	//[Help_Attribute(74,"Arun")]
	//[Help_Attribute(75,"Minion",comment_1 = "Help_AttributeComment")]

	public class myclass
	{
		public int method_1(int x)
		{
			return x + method_2 (x);
		}

		public int method_2(int x)
		{
			return x*10;
		}
		public class Mainclass
		{
			public static void Main(String[] args)
			{
				myclass mc = new myclass ();
				Console.WriteLine ("Calling Method_1(25),Result={0}",mc.method_1(25));
				Console.WriteLine ("Calling Method_2(25),Result={0}",mc.method_2(25));
			}
		}
	}
}
