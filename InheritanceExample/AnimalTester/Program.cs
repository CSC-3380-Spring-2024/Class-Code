public class AnimalTester{
	public static void Main(){
		Dog jake = new Dog("Jake");
		Husky dale = new Husky("Dale");

		//Console.WriteLine(Dog.numDogs); //NOTE - If you uncomment this line, you will see an error since numDogs is private
		Console.WriteLine(Animal.numAnimals);

		jake.Speak();
		dale.Speak();

		//Console.WriteLine(dale.species); //NOTE - If you uncomment this line, you will see an error since species is internal

		//jake.Lick(); //NOTE - If you uncomment this line, you will see an error since Lick() is protected
		//dale.Lick(); //NOTE - If you uncomment this line, you will see an error since Lick() is protected
	}
}
