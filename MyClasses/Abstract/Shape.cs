namespace MyClasses.Abstract
{
	public abstract class Shape
	{
		public abstract double Area();
	}

	// Abstract Class Derived
	public class Circle : Shape
	{
		private readonly double radius;

		public Circle(double radius)
		{
			this.radius = radius;
		}

		public override double Area()
		{
			return Math.PI * radius * radius;
		}
	}

}
