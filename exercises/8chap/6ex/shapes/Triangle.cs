using System;
namespace Shapes
{
	public class Triangle : GeometricFigure
	{
		public Triangle (double height,double width) : base(height,width){}
		
		public override GeometricFigure ComputeArea ()
		{
			 area = Width*Height*.5;
			 return this;
		}
		 
	}
}

