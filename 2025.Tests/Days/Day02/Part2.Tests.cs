using System.Reflection;
using AdventOfCode2025.Days.Day02;

namespace AdventOfCode2025.Tests.Day02;

public class Part2Tests
{
    [Fact]
    public void Part2_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        var input = @"11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

        // Act
        var result = Part2.Solution(input);

        // Assert
        Assert.Equal(4174379265, result);
    }

    [Fact]
    public void IsInvalidNumber_99_1_ReturnsTrue()
    {
        Assert.True(Part2.IsInvalidNumber(99, 1));
    }

    [Fact]
    public void IsInvalidNumber_99_2_ReturnsFalse()
    {
        Assert.False(Part2.IsInvalidNumber(99, 2));
    }

    [Fact]
    public void SplitIntoRanges_95_512()
    {
        Assert.Equal([(95, 99), (100, 512)], Part2.SplitIntoRanges(95, 512));
    }
}
