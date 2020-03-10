using System;

namespace Attributes_4
{
	[AttributeUsage(AttributeTargets.Class)]

	public class FunwithAttribute:Attribute
	{
		String company;
		public FunwithAttribute(String s)
		{
			this.company = s;
		}
	
		public string company_1 {
			get;
			set;
		}
	}
	[FunwithAttribute("HCL Technologies")]
	public class test
	{
		public test (String name,String country)
		{
			this.Empname = name;
			this.Country = country;
		}
		public String filldetails()
		{
			String str = Empname + "_" + Country;
			return str;
		}
		private String Empname,Country;
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			test t = new test ("MCA","India");
			Console.WriteLine ("Result:{0}",t.filldetails());
		}
	}
}
