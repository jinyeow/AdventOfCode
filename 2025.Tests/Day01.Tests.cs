using AdventOfCode2025.Days;

namespace AdventOfCode2025.Tests;

public class Day01Tests
{
    [Fact]
    public void Part1_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        string input = @"L68
L30
R48
L5
R60
L55
L1
L99
R14
L82";

        // Act
        int result = Day01.Part1(input);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Part2_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        string input = @"L68
L30
R48
L5
R60
L55
L1
L99
R14
L82";

        // Act
        int result = Day01.Part2(input);

        // Assert
        Assert.Equal(6, result);
    }
}
