using System;

public class Cards
{
	public void main(string[] args)
	{
		int countCards = 52;
		int countRows = countCards / 3;
		int remainsCards = countCards % 3;
		Console.WriteLine(countRows);
		Console.WriteLine(remainsCards);
	}
}
