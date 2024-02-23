public abstract class Animal{
	public static int numAnimals = 0;
	protected string name;

	public Animal(){
		numAnimals++;
		name = $"{numAnimals}";
	}

	public Animal(string name){
		numAnimals++;
		this.name = name;
	}

	public virtual void Speak(){
		Console.WriteLine("I'm Alive!!!");
	}

	public abstract void Move();

    public override string ToString()
    {

        return name;
    }
	public static void Main(){}
}