using System;

namespace Shapes
{
	public class Shapes
	{ 
		public virtual void Draw()
		{                                          
			Console.WriteLine ("Performing Base Class Drawing task.");
		}
	}
	class circle:Shapes
	{
		public override void Draw()
		{
			Console.WriteLine ("Drawing a Circle.");
			base.Draw ();
		}
	}

	class triangle:Shapes
	{
		public override void Draw()
		{
			Console.WriteLine ("Drawing a Triangle.");
			base.Draw ();
		}
	}

	class rectangle:Shapes
	{
		public override void Draw()
		{
			Console.WriteLine ("Drawing a Rectangle.");
			base.Draw ();
		}
	}
	class mainclass
	{
		public static void Main(String[] args)
		{
			System.Collections.Generic.List<Shapes>shape = new System.Collections.Generic.List<Shapes>();
			shape.Add (new circle());
			shape.Add(new triangle());
			shape.Add(new rectangle());
			foreach (var sh in shape) 
			{
				sh.Draw ();
			}
		}
	}
}