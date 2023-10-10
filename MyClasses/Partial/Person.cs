namespace MyClasses.Partial
{
	public partial class PPerson
	{
		public string FirstName { get; set; }
	}

	// Partial Class (Another File)
	public partial class PPerson
	{
		public string LastName { get; set; }

		public string GetFullName()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
