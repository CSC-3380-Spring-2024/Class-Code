interface Animal{
	void Move();
	void Speak();
}

public class Dog : Animal{
	private static int numDogs = 0;
	private string name;
	public Dog():base(){
		numDogs++;
	}
	public Dog(string name){
		this.name = name;
		numDogs++;
	}

    public void Move()
    {
        Console.WriteLine("Slide to the Left");
    }

    public void Speak()
    {
        Console.WriteLine($"Woof! My name is {name}!");
    }

	protected void Lick(){
		Console.WriteLine("YAY, HUMAN!!!!!");
	}

	new public static void Main(){
	}
}

public class Cat : Animal{
	public Cat(){}

	public void Move(){
		Console.WriteLine("Get away from me");
	}

	public void Speak(){
		Console.WriteLine("Meow");
	}
}
