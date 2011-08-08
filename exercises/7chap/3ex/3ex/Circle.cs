using System;
namespace ex
{
	public class Circle
	{
		private double radius,area,diameter;
		public Circle ()
		{
			radius = 1;
			diameter = 2*radius;
			area = Math.PI*radius*radius;
		}
		public double Radius {
			get {
				return this.radius;
			}
			set {
				radius = value;
				diameter = 2*radius;
				area = Math.PI*radius*radius;
			}
		}

		public double Area {
			get {
				return this.area;
			}
		}

		public double Diameter {
			get {
				return this.diameter;
			}
		}
		public override string ToString ()
		{
			return string.Format ("[Circle: radius={0}, diameter={1}, area={2}]", 
			                      radius, 
			                      diameter,
			                      area.ToString("N2")); 
		}

	}
}

