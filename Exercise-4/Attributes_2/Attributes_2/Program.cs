using System;

namespace Attributes_2
{
	[AttributeUsage(AttributeTargets.Class|
	                AttributeTargets.Constructor|
	                AttributeTargets.Field|
	                AttributeTargets.Property,
	                AllowMultiple=true)]

	public class BugfixAttribute:System.Attribute
	{
		private int bugid;
		private String comment,date,programmer;

		BugfixAttribute(int bugid, String programmer, String date)
		{
			this.bugid = bugid;
			this.comment = comment;
			this.date = date;
		}

		public int bugid_1
		{
			get
			{
				return bugid;
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
				comment=value;
			}
		}

		public String date_1
		{
			get
			{
				return date;
			}
		}

		public String programmer_1
		{
			get
			{
				return programmer;
			}
		}
	}

	public class math
	{
		public double fun1(double val1)
		{
			return val1 + fun2 (val1);
		}

		public double fun2(double val2)
		{
			return val2 / 3;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			math m = new math ();
			Console.WriteLine ("Calling return 1, Result={0}",m.fun2(5));
		}
	}
}
