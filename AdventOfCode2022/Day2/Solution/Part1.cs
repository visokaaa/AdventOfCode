namespace Day2.Solution;

internal static class Part1
{
    public static Dictionary<string, int> Scores = new()
    {
        { "B X", 1 },
        { "C Y", 2 },
        { "A Z", 3 },
        { "A X", 4 },
        { "B Y", 5 },
        { "C Z", 6 },
        { "C X", 7 },
        { "A Y", 8 },
        { "B Z", 9 }
    };

    internal static int CalculateTotalScore(string[] lines)
    {
        return lines.Sum(line => Scores[line]);
    }
}