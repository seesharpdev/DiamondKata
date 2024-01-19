using System;

class DiamondPrinter
{
	static void Main(string[] args)
	{
		if (args.Length == 1 || (args.Length == 2 && args[1].Equals("-r", StringComparison.OrdinalIgnoreCase)))
		{
			char inputChar = args[0].ToUpper()[0];
			bool renderUnderscore = args.Length == 2 && args[1].Equals("-r", StringComparison.OrdinalIgnoreCase);

			if (char.IsLetter(inputChar))
			{
				PrintDiamond(inputChar, renderUnderscore);
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

	static void PrintDiamond(char midChar, bool renderUnderscore)
	{
		int diamondSize = midChar - 'A' + 1;

		// Print upper half of the diamond
		for (int row = 0; row < diamondSize; row++)
		{
			// Print leading spaces or underscores before the first character
			for (int leadingSpaces = 0; leadingSpaces < diamondSize - row - 1; leadingSpaces++)
			{
				Console.Write(renderUnderscore ? "_" : " ");
			}

			// Print the first character in the row
			Console.Write((char)('A' + row));

			// If it's not the first row, print the spaces or underscores between characters
			if (row > 0)
			{
				for (int spacesBetween = 0; spacesBetween < row * 2 - 1; spacesBetween++)
				{
					Console.Write(renderUnderscore ? "_" : " ");
				}

				// Print the last character in the row
				Console.Write((char)('A' + row));
			}

			// Print trailing spaces or underscores after the last character in the row
			for (int trailingSpaces = 0; trailingSpaces < diamondSize - row - 1; trailingSpaces++)
			{
				Console.Write(renderUnderscore ? "_" : " ");
			}

			// Move to the next line after printing the row
			Console.WriteLine();
		}

		// Print lower half of the diamond
		for (int row = diamondSize - 2; row >= 0; row--)
		{
			// Print leading spaces or underscores before the first character
			for (int leadingSpaces = 0; leadingSpaces < diamondSize - row - 1; leadingSpaces++)
			{
				Console.Write(renderUnderscore ? "_" : " ");
			}

			// Print the first character in the row
			Console.Write((char)('A' + row));

			// If it's not the first row, print the spaces or underscores between characters
			if (row > 0)
			{
				for (int spacesBetween = 0; spacesBetween < row * 2 - 1; spacesBetween++)
				{
					Console.Write(renderUnderscore ? "_" : " ");
				}

				// Print the last character in the row
				Console.Write((char)('A' + row));
			}

			// Print trailing spaces or underscores after the last character in the row
			for (int trailingSpaces = 0; trailingSpaces < diamondSize - row - 1; trailingSpaces++)
			{
				Console.Write(renderUnderscore ? "_" : " ");
			}

			// Move to the next line after printing the row
			Console.WriteLine();
		}
	}
}
