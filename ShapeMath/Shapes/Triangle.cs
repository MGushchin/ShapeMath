
namespace ShapeMath.Shapes
{
	public class Triangle : Shape
	{
		private double sideA, sideB, sideC;

		private bool rectangular;
		public bool Rectangular => rectangular;

		public Triangle(double _sideA, double _sideB, double _sideC) 
		{ 
			sideA = _sideA;
			sideB = _sideB;
			sideC = _sideC;

			rectangleCheck();
		}

		public override double GetArea()
		{
			double perimeter = GetPerimeter();

			double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));

			return area;
		}

		public double GetPerimeter()
		{
			return (sideA + sideB + sideC) / 2;
		}

		private void rectangleCheck()
		{
			if (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
				rectangular = true;
			else
				rectangular = false;
		}
	}
}
