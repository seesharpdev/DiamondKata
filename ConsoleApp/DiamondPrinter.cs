using System;

public class DiamondPrinter
{
	public static string GenerateDiamond(char midChar, bool renderUnderscore)
	{
		int diamondSize = midChar - 'A' + 1;
		var diamondBuilder = new System.Text.StringBuilder();

		// Generate upper half of the diamond
		for (int row = 0; row < diamondSize; row++)
		{
			// Append leading spaces or underscores before the first character
			diamondBuilder.Append(new string(renderUnderscore ? '_' : ' ', diamondSize - row - 1));

			// Append the first character in the row
			diamondBuilder.Append((char)('A' + row));

			// If it's not the first row, append the spaces or underscores between characters
			if (row > 0)
			{
				diamondBuilder.Append(new string(renderUnderscore ? '_' : ' ', row * 2 - 1));

				// Append the last character in the row
				diamondBuilder.Append((char)('A' + row));
			}

			// Append trailing spaces or underscores after the last character in the row
			diamondBuilder.Append(new string(renderUnderscore ? '_' : ' ', diamondSize - row - 1));

			// Move to the next line after appending the row
			diamondBuilder.AppendLine();
		}

		// Generate lower half of the diamond
		for (int row = diamondSize - 2; row >= 0; row--)
		{
			// Append leading spaces or underscores before the first character
			diamondBuilder.Append(new string(renderUnderscore ? '_' : ' ', diamondSize - row - 1));

			// Append the first character in the row
			diamondBuilder.Append((char)('A' + row));

			// If it's not the first row, append the spaces or underscores between characters
			if (row > 0)
			{
				diamondBuilder.Append(new string(renderUnderscore ? '_' : ' ', row * 2 - 1));

				// Append the last character in the row
				diamondBuilder.Append((char)('A' + row));
			}

			// Append trailing spaces or underscores after the last character in the row
			diamondBuilder.Append(new string(renderUnderscore ? '_' : ' ', diamondSize - row - 1));

			// Move to the next line after appending the row
			diamondBuilder.AppendLine();
		}

		// Return the generated diamond as a string
		return diamondBuilder.ToString();
	}
}
