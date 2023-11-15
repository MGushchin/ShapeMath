
namespace ShapeMath.Shapes
{
	public class Circle : Shape
	{
		private double radius;

		public Circle(double _radius)
		{
			radius = _radius;
		}

		public override double GetArea()
		{
			double area = Math.PI * Math.Pow(radius, 2);

			return area;
		}


	}
}
