using System;
namespace Shapes
{
	public abstract class GeometricFigure
	{
		protected double height,width,area;
		
		public GeometricFigure (double height, double width)
		{
			this.Height = height;
			this.Width = width;
		}

		
		public double Height {
			get {
				return this.height;
			}
			set {
				height = value;
			}
		}

		public double Width {
			get {
				return this.width;
			}
			set {
				width = value;
			}
		}
		
		public double Area {
			get {
				return this.area;
			}
		}
		
		public override string ToString ()
		{
			return string.Format ("[GeometricFigure: Height={0}, Width={1}, Area={2}]", Height, Width, Area);
		}

		public abstract GeometricFigure ComputeArea();
	}
}

