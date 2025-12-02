using System.ComponentModel;

namespace AdventOfCode2025.Days;

public static class Day01
{
    public static void Solve()
    {
        var input = File.ReadAllText("Inputs/Day01/day01.txt");

        Console.WriteLine($"Part 1: {Part1(input)}");
        Console.WriteLine($"Part 2: {Part2(input)}");
    }

    public static int Part1(string input)
    {
        var password = 0;
        var start = 50;
        foreach (var line in input.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        {
            var change = int.Parse(line[1..]);
            if (line.StartsWith('R'))
            {
                start += change;
            }
            else if (line.StartsWith('L'))
            {
                start -= change;
            }
            if (start % 100 == 0)
            {
                password++;
            }
        }
        return password;
    }

    public static int Part2(string input)
    {
        var password = 0;
        var start = 50;
        var previouslyPositive = true;
        var previouslyZero = false;
        foreach (var line in input.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        {
            var change = int.Parse(line[1..]);
            if (line.StartsWith('R'))
            {
                start += change;
            }
            else if (line.StartsWith('L'))
            {
                start -= change;
            }

            if (start % 100 == 0 || (!previouslyZero && start > 0 != previouslyPositive))
            {
                password++;
            }
            else if (start > 100 && start / 100 > 0)
            {
                password += start / 100;
            }
            else if (start < -100 && start / -100 > 0)
            {
                password += start / -100;
            }
            start %= 100;
            previouslyPositive = start > 0;
            previouslyZero = start == 0;
        }
        return password;
    }
}
