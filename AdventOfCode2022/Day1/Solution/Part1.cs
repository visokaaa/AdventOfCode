using Day1.Models;

namespace Day1.Solution;

internal static class Part1
{
    public static int FindMaxCaloriesElf(IEnumerable<Elf> elfs)
    {
        return elfs.Max(x => x.CaloriesSum);
    }
}

