using System;
using Shapes;

namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			GeometricFigure[] g = new GeometricFigure[3];
			g[0] = new Rectangle(10,20).ComputeArea();
			g[1] = new Square(5).ComputeArea();
			g[2] = new Triangle(5,10).ComputeArea();
			
			Console.WriteLine("displaying datas...");

			DisplayData(g);
			
			for (int i=0; i<g.Length; i++)
			{
				g[i].Height = i*12+1;
				g[i].ComputeArea();
			}
			
			Console.WriteLine("changed stuff...redisplaying");
			
			DisplayData(g);
		}
		
		public static void DisplayData(GeometricFigure[] g)
		{
			foreach (GeometricFigure item in g) {
				Console.WriteLine(item);
			}
		}
	}
}

