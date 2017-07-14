using System;

namespace Operator_Overloading
{
	class Box
	{
		int length,breadth,height;

		public void setLength(int len)
		{
			length = len;
		}
		public void setBreadth(int bre)
		{
			breadth = bre;
		}
		public void setHeight(int hgt)
		{
			height = hgt;
		}
		public int volume()
		{
			return length * breadth * height;
		}
		public static Box operator+ (Box b,Box c)
		{
			Box box = new Box ();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;
			return box;
		}
	}
	class operation
	{
		public static void Main(string[] args)
		{
			int volume;
			Box box1=new Box();
			Box box2=new Box();
			Box box3=new Box();

			box1.setLength (10);
			box1.setBreadth (15);
			box1.setHeight (8);
			volume=box1.volume ();
			Console.WriteLine ("Box-1 Volume is:"+volume);

			box2.setLength (15);
			box2.setBreadth (6);
			box2.setHeight (8);
			volume=box2.volume ();
			Console.WriteLine ("Box-2 Volume is:"+volume);

			box3 = box1 + box2;
			volume = box3.volume ();
			Console.WriteLine ("Box-3 Volume is:"+volume);
		}
	}
}
