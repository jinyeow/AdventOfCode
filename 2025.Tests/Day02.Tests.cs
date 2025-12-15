using System.Reflection;
using AdventOfCode2025.Days;

namespace AdventOfCode2025.Tests;

public class Day02Tests
{
    [Fact]
    public void Part1_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        var input = @"11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

        // Act
        var result = Day02.Part1(input);

        // Assert
        Assert.Equal(1227775554, result);
    }

    [Fact]
    public void Part2_WithExampleInput_ReturnsExpectedResult()
    {
        // Arrange
        var input = @"11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

        // Act
        var result = Day02.Part2(input);

        // Assert
        Assert.Equal(4174379265, result);
    }

    [Fact]
    public void IsInvalidNumber_55_ReturnsTrue()
    {
        Assert.True(Day02.IsInvalidNumber(55));
    }

    [Fact]
    public void IsInvalidNumber_6464_ReturnsTrue()
    {
        Assert.True(Day02.IsInvalidNumber(6464));
    }

    [Fact]
    public void IsInvalidNumber_123123_ReturnsTrue()
    {
        Assert.True(Day02.IsInvalidNumber(123123));
    }

    [Fact]
    public void IsInvalidNumber_101_ReturnsFalse()
    {
        Assert.False(Day02.IsInvalidNumber(101));
    }

    [Fact]
    public void IsInvalidNumber_1234_ReturnsFalse()
    {
        Assert.False(Day02.IsInvalidNumber(1234));
    }

    [Fact]
    public void IsInvalidNumber_11_ReturnsTrue()
    {
        Assert.True(Day02.IsInvalidNumber(11));
    }

    [Fact]
    public void ConstructInvalidNumber_5_Returns55()
    {
        Assert.Equal(55, Day02.ConstructInvalidNumber(5));
    }

    [Fact]
    public void ConstructInvalidNumber_64_Returns6464()
    {
        Assert.Equal(6464, Day02.ConstructInvalidNumber(64));
    }

    [Fact]
    public void ConstructInvalidNumber_123_Returns123123()
    {
        Assert.Equal(123123, Day02.ConstructInvalidNumber(123));
    }

    [Fact]
    public void ConstructInvalidNumber_11885_Returns1188511885()
    {
        Assert.Equal(1188511885, Day02.ConstructInvalidNumber(11885));
    }

    [Fact]
    public void GetFirstHalf_1010_2_Returns10()
    {
        Assert.Equal(10, Day02.GetFirstHalf(1010, 2));
    }

    [Fact]
    public void GetFirstHalf_123123_3_Returns123()
    {
        Assert.Equal(123, Day02.GetFirstHalf(123123, 3));
    }

    [Fact]
    public void GetFirstHalf_1188511885_5_Returns11885()
    {
        Assert.Equal(11885, Day02.GetFirstHalf(1188511885, 5));
    }

    [Fact]
    public void GetFirstHalf_99_1_Returns9()
    {
        Assert.Equal(9, Day02.GetFirstHalf(99, 1));
    }

    [Fact]
    public void SplitIntoEvenLengthRanges_99_1050_Returns()
    {
        Assert.Equal([(99,99), (1000, 1050)], Day02.SplitIntoEvenLengthRanges(99, 1050));
    }

    [Fact]
    public void SplitIntoEvenLengthRanges_100_999_Returns()
    {
        Assert.Equal([], Day02.SplitIntoEvenLengthRanges(100, 999));
    }

    [Fact]
    public void SplitIntoEvenLengthRanges_1010_2020_Returns()
    {
        Assert.Equal([(1010, 2020)], Day02.SplitIntoEvenLengthRanges(1010, 2020));
    }

    [Fact]
    public void SplitIntoEvenLengthRanges_1050_99_Returns()
    {
        Assert.Equal([], Day02.SplitIntoEvenLengthRanges(1050, 99));
    }

    [Fact]
    public void SumInvalidIdsInRange_11_22_Returns33()
    {
        Assert.Equal(33, Day02.SumInvalidIDsInRange(11, 22));
    }

    [Fact]
    public void SumInvalidIdsInRange_95_115_Returns99()
    {
        Assert.Equal(99, Day02.SumInvalidIDsInRange(95, 115));
    }

    [Fact]
    public void SumInvalidIdsInRange_998_1012_Returns1010()
    {
        Assert.Equal(1010, Day02.SumInvalidIDsInRange(998, 1012));
    }
}
