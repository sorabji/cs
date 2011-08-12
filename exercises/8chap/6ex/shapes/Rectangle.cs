using System;
namespace Shapes
{
	public class Rectangle : GeometricFigure
	{
		public Rectangle(double height,double width) : base(height,width){}
		
		public override GeometricFigure ComputeArea ()
		{
			area = Height*Width;
			return this;
		}
	}
}

