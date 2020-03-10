using System;

namespace third_five
{
	delegate bool D();
	delegate bool D2(int a);



	class MainClass
	{
		D del;
		D2 del2;
		public void Test_method(int input)
		{
			int j=0;
			del=()=>{j=10;return j>input;};
			del2=(x)=>{return x==j;};
			bool result=del();
			Console.WriteLine("j={0},b={1}",j,result);

		}
	


		public static void Main (string[] args)
		{
			MainClass text=new MainClass();
			text.Test_method(5);
			bool result1=text.del2(10);
			Console.WriteLine (result1);
		}
	}
}
