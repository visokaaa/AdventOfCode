namespace Day4;

internal class Part2
{
    internal static object CountTouchedPairs(string[] lines)
    {
        var assigmentPairsCount = 0;

        foreach (var line in lines)
        {
            var pairs = line.Split(",");
            var firstSection = pairs[0];
            var secondSection = pairs[1];

            if (SectionsAreTouched(firstSection, secondSection))
            {
                assigmentPairsCount++;
            }
        }

        return assigmentPairsCount;
    }

    private static bool SectionsAreTouched(string firstSection, string secondSection)
    {
        var firstSectionNumbers = firstSection.ParseSection();
        var secondSectionNumbers = secondSection.ParseSection();

        var firstSectionStart = firstSectionNumbers.Item1;
        var firstSectionEnd = firstSectionNumbers.Item2;

        var secondSectionStart = secondSectionNumbers.Item1;
        var secondSectionEnd = secondSectionNumbers.Item2;

        return firstSectionStart <= secondSectionEnd && secondSectionStart <= firstSectionEnd;


    }
}
