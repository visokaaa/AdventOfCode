namespace Day3.Solution;

internal static class Part1
{
    internal static object CalculatePrioritiesSum(string[] lines)
    {
        var sum = 0;

        foreach(string line in lines)
        {
            var firstCompartment = line.Substring(0, line.Length / 2);
            var secondCompartment = line.Substring(line.Length / 2);

            var commonChar = firstCompartment.Intersect(secondCompartment).First();
            sum += commonChar.PriorityNumber();
        }

        return sum;
    }
}
