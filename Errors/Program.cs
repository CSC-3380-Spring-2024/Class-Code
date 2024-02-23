public class Errors{

	public static void PrintList(List<int> list){
		string printString = "[";

		foreach(int e in list){
			printString += $"{e},";
		}
		printString += "]";

		Console.WriteLine(
			$"Hashcode: {list.GetHashCode()}\nContents: {printString}\n\n"
		);
	}
	public static void Main(){
		List<int> intList1 = new List<int>([1,2,3,4,5]);
		List<int> intList2 = intList1; //NOTE - Shallow Copy
		List<int> intList3 = new List<int>(); //NOTE - Deep Copy
		List<int> intList4 = new List<int>(intList1); //NOTE - Deep Copy
		List<int> intList5 = new List<int>([1,2,3,4,5]);

		Console.WriteLine("Before manipulation");
		PrintList(intList1);
		PrintList(intList2);
		PrintList(intList3);
		PrintList(intList4);
		PrintList(intList5);

		//NOTE -  This deep copies intList1 to intList3
		foreach(int e in intList1){
			intList3.Add(e);
		}

		intList2.RemoveAt(0);
		intList1.Add(22);

		Console.WriteLine("After manipulation");
		PrintList(intList1);
		PrintList(intList2);
		PrintList(intList3);
		PrintList(intList4);
		PrintList(intList5);

		try{
			throw new IndexOutOfRangeException();
		}
		catch(FileNotFoundException e){
			Console.WriteLine("No file");
		}
		catch(Exception e){
			Console.WriteLine("Some other exception");
		}

	}
}
