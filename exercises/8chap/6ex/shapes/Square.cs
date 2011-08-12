using System;
namespace Shapes
{
	public class Square : Rectangle
	{
		public Square(double height, double width) : base(height,width)
		{
			this.height = Math.Max(height,width);
			this.width = this.height;
		}
		
		public Square(double height) : this(height,height)
		{
		}
	}
}

