using MyClasses.Abstract;
using MyClasses.Nested;
using MyClasses.Partial;
using MyClasses.Regular;
using MyClasses.Sealed;
using MyClasses.Static;

public class Program
{
	public static void Main(string[] args)
	{
		// Regular Class Example
		Person person = new Person
		{
			Name = "John",
			Age = 30
		};
		Console.WriteLine($"Regular Class - Name: {person.Name}, Age: {person.Age}");

		// Abstract Class Example
		Shape circle = new Circle(5);
		double circleArea = circle.Area();
		Console.WriteLine($"Abstract Class - Circle Area: {circleArea}");

		// Sealed Class Example
		Configuration config = new Configuration();
		Console.WriteLine($"Sealed Class - Configuration: {config.ToString()}");

		// Static Class Example
		double result = MathHelper.Add(10, 20);
		Console.WriteLine($"Static Class - Math Helper Result: {result}");

		// Partial Class Example
		var person2 = new PPerson
		{
			FirstName = "Alice",
			LastName = "Smith"
		};
		Console.WriteLine($"Partial Class - Full Name: {person2.GetFullName()}");

		// Nested Class Example
		School.Student student = new School.Student
		{
			Name = "Bob",
			Grade = "A"
		};
		Console.WriteLine($"Nested Class - Student Name: {student.Name}, Grade: {student.Grade}");
	}
}
