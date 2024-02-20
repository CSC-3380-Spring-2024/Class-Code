//sealed class Dog : Animal{ //NOTE - Uncomment this line and comment-out the line below, and an error will occur since Husky can no longer inherit the Dog class
public class Dog : Animal{
	private static int numDogs = 0;
	public Dog():base(){
		numDogs++;
	}
	public Dog(string name):base(name){
		numDogs++;
	}

    public override void Move()
    {
        Console.WriteLine("Slide to the Left");
    }

    public override void Speak()
    {
        Console.WriteLine($"Woof! My name is {name}!");
    }

	protected void Lick(){
		Console.WriteLine("YAY, HUMAN!!!!!");
	}

	new public static void Main(){
		Dog jake = new Dog("Jake");
		Husky dale = new Husky("Dale");

		Console.WriteLine(Dog.numDogs);
		Console.WriteLine(Animal.numAnimals);

		jake.Speak();
		dale.Speak();

		Console.WriteLine(dale.species);

		jake.Lick();
		dale.Lick();
	}
}

public class Husky : Dog{
	internal string species = "Husky";

	public Husky():base(){}
	public Husky(string name):base(name){}

    public override void Speak()
    {
        base.Speak();
		Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
		//Console.WriteLine($"I am the {numDogs}");  //NOTE - If you uncomment this line, you will see an error since numDogs is private
    }
}
