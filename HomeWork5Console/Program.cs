using System;

class Program
{
	static void Main()
	{
		// Ask the user for their personal data
		Console.WriteLine("Please provide your personal data:");

		// Read the first name
		Console.Write("First Name: ");
		string firstName = Console.ReadLine();

		// Read the last name
		Console.Write("Last Name: ");
		string lastName = Console.ReadLine();

		// Read the phone number
		Console.Write("Phone Number: ");
		string phoneNumber = Console.ReadLine();

		// Read the email address
		Console.Write("Email Address: ");
		string email = Console.ReadLine();

		// Read the height
		Console.Write("Height (in cm): ");
		if (double.TryParse(Console.ReadLine(), out double height))
		{
			// Read the weight
			Console.Write("Weight (in kg): ");
			if (double.TryParse(Console.ReadLine(), out double weight))
			{
				// Display a summary of the data
				Console.WriteLine("\nSummary:");
				Console.WriteLine("First Name: " + firstName);
				Console.WriteLine("Last Name: " + lastName);
				Console.WriteLine("Phone Number: " + phoneNumber);
				Console.WriteLine("Email Address: " + email);
				Console.WriteLine("Height: " + height + " cm");
				Console.WriteLine("Weight: " + weight + " kg");
			}
			else
			{
				Console.WriteLine("Invalid value for weight!");
			}
		}
		else
		{
			Console.WriteLine("Invalid value for height!");
		}

		Console.ReadKey();
	}
}