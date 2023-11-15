using ShapeMath.Shapes;

namespace ShapeMath.Tests
{
	public class CircleTests
	{
		[Fact]
		public void Area()
		{
			// Arrange
			var circle = new Circle(2);

			// Act
			double area = circle.GetArea();

			// Assert
			Assert.Equal(12.566370614359172, area);
		}
	}
}
