using System;

public class SingletonConsolePrintor
{
	private int currentIndex = 0;
	private int maxLengthRow = 5;
	private int maxLengthColumn = 2;

	private static SingletonConsolePrintor singleton;

	private SingletonConsolePrintor() { }

	public static SingletonConsolePrintor GetSingletonConsolePrintor()
	{
		if (SingletonConsolePrintor.singleton == null) SingletonConsolePrintor.singleton = new SingletonConsolePrintor();
		return singleton;
	}

	public void Print(string price,string data)
	{
		AskForClearScreenIfNeeded();
		ReturnCariageIfNeeded();
		Console.Write($"[ {data} ({price}e) ]\t");
		currentIndex++;
	}


	private void AskForClearScreenIfNeeded()
	{
		if (currentIndex == (maxLengthRow * maxLengthColumn))
		{
			Console.Write("\n\nENTER FOR NEXT PAGE ...");
			var input = Console.ReadLine();
			Console.Clear();
			currentIndex = 0;
		}

	}

	private void ReturnCariageIfNeeded()
	{
		if ((currentIndex % maxLengthColumn) == 0) Console.WriteLine();
	}
}
