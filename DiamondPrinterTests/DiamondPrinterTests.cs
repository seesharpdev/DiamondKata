using System;
using Xunit;

public class DiamondPrinterTests
{
	[Theory]
	[InlineData('A', false, "A\r\n")]
	[InlineData('B', false, " A \r\nB B\r\n A \r\n")]
	[InlineData('C', false, "  A  \r\n B B \r\nC   C\r\n B B \r\n  A  \r\n")]
	[InlineData('A', true, "A\r\n")]
	[InlineData('B', true, "_A_\r\nB_B\r\n_A_\r\n")]
	[InlineData('C', true, "__A__\r\n_B_B_\r\nC___C\r\n_B_B_\r\n__A__\r\n")]
	public void GenerateDiamond_ShouldGenerateCorrectDiamond(char midChar, bool renderUnderscore, string expectedOutput)
	{
		// Arrange

		// Act
		string result = DiamondPrinter.GenerateDiamond(midChar, renderUnderscore);

		// Assert
		Assert.Equal(expectedOutput, result);
	}

	[Fact]
	public void GenerateDiamond_InvalidInput_ShouldReturnEmptyString()
	{
		// Arrange
		char invalidChar = '1';

		// Act
		string result = DiamondPrinter.GenerateDiamond(invalidChar, false);

		// Assert
		Assert.Equal(string.Empty, result);
	}
}
