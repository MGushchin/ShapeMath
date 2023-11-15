using ShapeMath.Shapes;

namespace ShapeMath.Tests
{
	public class CircleTests
	{
		[Fact]
		public void Area()
		{
			// Arrange
			var circle = new Circle(4);

			// Act
			double area = circle.GetArea();

			// Assert
			Assert.Equal(50.26548245743669, area);
		}
	}
}
