using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Transactions;

namespace AdventOfCode2025.Days;

public static class Day02
{
    public static void Solve()
    {
        var input = File.ReadAllText("Inputs/Day02/day02.txt");

        Console.WriteLine($"Part 1: {Part1(input)}");
        Console.WriteLine($"Part 2: {Part2(input)}");
    }

    public static long Part1(string input)
    {
        var total = (long)0;
        var ranges = input.Split(",");
        foreach (var range in ranges)
        {
            var parts = range.Split("-");
            var start = long.Parse(parts[0]);
            var end = long.Parse(parts[1]);
            total += SumInvalidIDsInRange(start, end);
        }
        return total;
    }

    public static int Part2(string input)
    {
        // TODO
        return 0;
    }

    public static bool IsInvalidNumber(long number)
    {
        var numberString = number.ToString();
        if (numberString.Length % 2 != 0)
        {
            return false;
        }

        var halfLength = numberString.Length / 2;
        var firstHalf = numberString[..halfLength];
        var secondHalf = numberString[halfLength..];

        return firstHalf == secondHalf;
    }

    public static long ConstructInvalidNumber(long firstHalf)
    {
        var length = firstHalf.ToString().Length;
        var factor = (long)Math.Pow(10, length);
        return ((firstHalf * factor) + firstHalf);
    }

    public static long GetFirstHalf(long number, int halfLength)
    {
        var numberString = number.ToString();
        return long.Parse(numberString[0..halfLength]);
    }

    public static List<(long start, long end)> SplitIntoEvenLengthRanges(long start, long end)
    {
        var subRanges = new List<(long, long)>();
        var current = start;

        while (current <= end)
        {
            var currentLength = current.ToString().Length;

            if (currentLength % 2 != 0)
            {
                current = (long)Math.Pow(10, currentLength);
                continue;
            }

            var subRangeEnd = (long)Math.Min(end, Math.Pow(10, currentLength) - 1);
            subRanges.Add((current, subRangeEnd));

            current = (long)Math.Pow(10, currentLength + 1);
        }

        return subRanges;
    }

    public static long SumInvalidIDsInRange(long start, long end)
    {
        if (start > end)
        {
            return 0;
        }

        var sum = (long)0;
        var subRanges = SplitIntoEvenLengthRanges(start, end);

        foreach (var (subStart, subEnd) in subRanges)
        {
            var digitCount = subStart.ToString().Length;
            var halfLength = digitCount / 2;
            var minFirstHalf = GetFirstHalf(subStart, halfLength);
            var maxFirstHalf = GetFirstHalf(subEnd, halfLength);

            for (var firstHalf = minFirstHalf; firstHalf <= maxFirstHalf; firstHalf++)
            {
                var invalidNumber = ConstructInvalidNumber(firstHalf);
                if (invalidNumber >= subStart && invalidNumber <= subEnd)
                {
                    sum += invalidNumber;
                }
            }
        }
        return sum;
    }
}
