using System.Reflection;
using AdventOfCode2025.Days;

namespace AdventOfCode2025.Tests;

public class Day02Tests
{
    [Fact]
    public void Part1_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        string input = @"11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

        // Act
        int result = Day02.Part1(input);

        // Assert
        Assert.Equal(1227775554, result);
    }

    [Fact]
    public void Part2_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        string input = @"";

        // Act
        int result = Day02.Part2(input);

        // Assert
    }
}
