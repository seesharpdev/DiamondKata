using System;

class DiamondPrinter
{
	static void Main(string[] args)
	{
		if (args.Length == 1)
		{
			char inputChar = args[0].ToUpper()[0];

			if (char.IsLetter(inputChar))
			{
				PrintDiamond(inputChar);
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid character.");
			}
		}
		else
		{
			Console.WriteLine("Usage: Diamond.exe <character>");
		}
	}

	static void PrintDiamond(char midChar)
	{
		// Calculate the size of the diamond based on the input character
		int diamondSize = midChar - 'A' + 1;

		// Print upper half of the diamond
		for (int row = 0; row < diamondSize; row++)
		{
			// Print leading spaces before the first character
			for (int leadingSpaces = 0; leadingSpaces < diamondSize - row - 1; leadingSpaces++)
			{
				Console.Write(" ");
			}

			// Print the first character in the row
			Console.Write((char)('A' + row));

			// If it's not the first row, print the spaces between characters
			if (row > 0)
			{
				for (int spacesBetween = 0; spacesBetween < row * 2 - 1; spacesBetween++)
				{
					Console.Write(" ");
				}

				// Print the second character in the row
				Console.Write((char)('A' + row));
			}

			// Move to the next line after printing the row
			Console.WriteLine();
		}

		// Print lower half of the diamond
		for (int row = diamondSize - 2; row >= 0; row--)
		{
			// Print leading spaces before the first character
			for (int leadingSpaces = 0; leadingSpaces < diamondSize - row - 1; leadingSpaces++)
			{
				Console.Write(" ");
			}

			// Print the first character in the row
			Console.Write((char)('A' + row));

			// If it's not the first row, print the spaces between characters
			if (row > 0)
			{
				for (int spacesBetween = 0; spacesBetween < row * 2 - 1; spacesBetween++)
				{
					Console.Write(" ");
				}

				// Print the second character in the row
				Console.Write((char)('A' + row));
			}

			// Move to the next line after printing the row
			Console.WriteLine();
		}
	}
}