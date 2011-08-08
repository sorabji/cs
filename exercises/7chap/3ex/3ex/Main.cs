using System;

namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Circle c1 = new Circle();
			Circle c2 = new Circle();
			Circle c3 = new Circle();
			
			c1.Radius = 0.2;
			c2.Radius = 50;
			
			Console.WriteLine(c1 + "\n" + c2 + "\n" + c3 + "\n");
			
		}
	}
}

