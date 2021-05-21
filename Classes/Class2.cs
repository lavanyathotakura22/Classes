// C# program to illustrate the
// Initialization of an object
using System;
namespace Classes
{

	// Class Declaration
	public class Class2
	{

		// Instance Variables
		String name;
		String breed;
		int age;
		String color;

		// Constructor Declaration of Class
		public Class2(String name, String breed,
					int age, String color)
		{
			this.name = name;
			this.breed = breed;
			this.age = age;
			this.color = color;
		}

		// Property 1
		public String getName()
		{
			return name;
		}

		// Property 2
		public String getBreed()
		{
			return breed;
		}

		// Property 3
		public int getAge()
		{
			return age;
		}

		// Property 4
		public String getColor()
		{
			return color;
		}

		// Method 1
		public String toString()
		{
			return ("Hi my name is " + this.getName()
					+ ".\nMy breed, age and color are " + this.getBreed()
					+ ", " + this.getAge() + ", " + this.getColor());
		}

		// Main Method
		public static void Main(String[] args)
		{

			// Creating object
			Class2 tuffy = new Class2("tuffy", "papillon", 5, "white");
			Console.WriteLine(tuffy.toString());
		}
	}
}
