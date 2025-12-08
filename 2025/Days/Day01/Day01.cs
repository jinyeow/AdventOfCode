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
        var current = 50;
        foreach (var line in input.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        {
            var previous = current;
            var change = int.Parse(line[1..]);

            if (int.Abs(change) > 100)
            {
                password += int.Abs(change / 100);
                change = (change % 100);
            }

            if (line.StartsWith('R'))
            {
                current += change;
            }
            else if (line.StartsWith('L'))
            {
                current -= change;
            }

            if (current % 100 == 0 ||
                current >= 100 ||
                current <= -100 ||
                (previous > 0 && current < 0) ||
                (previous < 0 && current > 0))
            {
                password++;
            }

            current %= 100;
        }
        return password;
    }
}
