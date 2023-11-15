using ShapeMath.Shapes;

namespace ShapeMath.Tests
{
	public class TriangleTests
	{
		[Fact]
		public void Perimeter()
		{
			// Arrange
			var triangle = new Triangle(5, 5, 6);

			// Act
			double area = triangle.GetPerimeter();

			// Assert
			Assert.Equal(8, area);
		}

		[Fact]
		public void Area()
		{
			// Arrange
			var triangle = new Triangle(5, 5, 6);

			// Act
			double area = triangle.GetArea();

			// Assert
			Assert.Equal(12, area);
		}

		[Fact]
		public void Rectangular()
		{
			// Arrange
			var triangle = new Triangle(8, 6, 10);

			// Act
			bool rectangular = triangle.Rectangular;

			// Assert
			Assert.True(rectangular);
		}
	}
}
