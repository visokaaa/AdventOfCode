namespace Day2.Solution;

internal class Part2
{
    public static Dictionary<string, int> Scores = new()
    {
        { "B X", 1 },
        { "C X", 2 },
        { "A X", 3 },
        { "A Y", 4 },
        { "B Y", 5 },
        { "C Y", 6 },
        { "C Z", 7 },
        { "A Z", 8 },
        { "B Z", 9 }
    };

    internal static int CalculateTotalScore(string[] lines)
    {
        return lines.Sum(line => Scores[line]);
    }
}
