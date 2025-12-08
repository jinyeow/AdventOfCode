using System.ComponentModel;

namespace AdventOfCode2025.Days;

public static class Day02
{
    public static void Solve()
    {
        var input = File.ReadAllText("Inputs/Day02/day02.txt");

        Console.WriteLine($"Part 1: {Part1(input)}");
        Console.WriteLine($"Part 2: {Part2(input)}");
    }

    public static int Part1(string input)
    {
        var total = 0;
        var line = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        var ranges = line.Split(',');

        foreach (var (firstValue, lastValue) in ranges.Split('-'))
        {
            var start = int.Parse(firstValue);
            var end = int.Parse(lastValue);

            if (firstValue.length % 2 == 0)
            {
                var sequenceLength = firstValue.length / 2;
            }
            else if (lastValue.length % 2 != 0)
            {
                var sequenceLength = lastValue.length / 2;
            }
            else
            {
                continue;
            }

            // check if the last sequenceLength digits of the lastValue are smaller than the first sequenceLength digits of the firstValue
            // if not, continue
            // find all the numbers where the first sL == last sL digits

            var invalidId = 0;
            total += invalidId;
        }
    }

    public static int Part2(string input)
    {
        // TODO
    }
}
