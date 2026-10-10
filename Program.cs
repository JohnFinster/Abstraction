namespace AbstractionTutorial
{

	class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to the Animal Sound Abstraction Tutorial!\n");

			var myCat = new Cat(); // Create a Cat object
			myCat.AnimalSound();  // Call the abstract method
			myCat.Sleep("The cat is sleeping.");  // Call the instance method

			var myDog = new Dog(); // Create a Dog object
			myDog.AnimalSound();  // Call the abstract method
			myDog.Sleep("The dog is sleeping.");  // Call the instance method

			var myPig = new Pig(); // Create a Pig object
			myPig.AnimalSound();  // Call the abstract method
			myPig.Sleep("The pig is sleeping.");  // Call the instance method

			Console.WriteLine("\nEnd of the Animal Sound Abstraction Tutorial!\n");
			Console.WriteLine("Any key to exit...");
			Console.ReadKey();
			System.Environment.Exit(0); // Exit the application
		}
	}
}


