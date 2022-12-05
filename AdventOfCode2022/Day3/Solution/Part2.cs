namespace Day3.Solution;

internal class Part2
{
    internal static object CalculatePrioritiesSum(string[] lines)
    {
        var sum = 0;

        for(int i = 0; i < lines.Length - 2; i+=3)
        {
            var firstLine = lines[i];
            var secondLine = lines[i + 1];
            var thirdLine = lines[i + 2];

            var commonChar = firstLine.Intersect(secondLine).Intersect(thirdLine).First();
            sum += commonChar.PriorityNumber();
        }

        return sum;
    }
}
