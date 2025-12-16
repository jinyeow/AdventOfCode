using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace AdventOfCode2025.Days.Day02;

public static class Part2
{
    public static void Solve()
    {
        var input = File.ReadAllText("Inputs/Day02/day02.txt");

        Console.WriteLine($"Part 2: {Solution(input)}");
    }

    public static long Solution(string input)
    {
        var candidates = new HashSet<long>();
        var ranges = input.Split(",");
        foreach (var range in ranges)
        {
            var parts = range.Split("-");
            var start = long.Parse(parts[0]);
            var end = long.Parse(parts[1]);
            var maxTotalDigits = parts[1].Length;

            for (var patternLength = 1; patternLength <= maxTotalDigits; patternLength++)
            {
                for (var repetition = 2; repetition <= maxTotalDigits / patternLength; repetition++)
                {
                    var f = (long)(Math.Pow(10, patternLength * repetition) - 1)/(Math.Pow(10, patternLength) - 1);
                    if (f > end)
                    {
                        continue;
                    }

                    var minimumPattern = (long)Math.Pow(10, patternLength - 1);
                    var maximumPattern = (long)Math.Pow(10, patternLength) - 1;

                    // lower <= n <= upper; where n = k * f
                    // So, lower/f <= k <= upper/f
                    var minimumPatternInRange = Math.Max(Math.Ceiling(start/f), minimumPattern);
                    var maximumPatternInRange = Math.Min(Math.Floor(end/f), maximumPattern);

                    if (minimumPatternInRange > maximumPatternInRange)
                    {
                        continue;
                    }

                    for (var pattern = minimumPatternInRange; pattern <= maximumPatternInRange; pattern++)
                    {
                        var invalidNumber = (long)pattern * f;
                        if (invalidNumber >= start && invalidNumber <= end)
                        {
                            candidates.Add((long)invalidNumber);
                        }
                    }
                }
            }
        }
        return candidates.Sum();
    }
}
