using System;

class Program
{
	static void Main(string[] args)
	{
		if (args.Length == 1 || (args.Length == 2 && args[1].Equals("-r", StringComparison.OrdinalIgnoreCase)))
		{
			char inputChar = args[0].ToUpper()[0];
			bool renderUnderscore = args.Length == 2 && args[1].Equals("-r", StringComparison.OrdinalIgnoreCase);

			if (char.IsLetter(inputChar))
			{
				string diamond = DiamondPrinter.GenerateDiamond(inputChar, renderUnderscore);
				Console.WriteLine(diamond);  // Print or use the string as needed
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid character.");
			}
		}
		else
		{
			Console.WriteLine("Usage: Diamond.exe <character> [-r]");
		}
	}
}
