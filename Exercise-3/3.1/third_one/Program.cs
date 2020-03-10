using System;

namespace Hai
{
	delegate int del(int x,int y);

	class MainClass
	{
		public static void Main (string[] args)
		{
			int z1,z2,z3;
			del d1=(x,y)=> x*y;
			del d2=(x,y)=> {return x*y;};
			del d3=delegate(int x,int y)
			{
				return x*y;
			};
			z1=d1(2,3);
			z2= d2(3,3);
			z3=d3(5,5);
			Console.WriteLine("The value of z1={0}",z1);
			Console.WriteLine("The Value of z2={0}",z2);
			Console.WriteLine("The Value of z3={0}",z3);

		}
	}
}
