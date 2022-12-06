namespace Day4;

internal class Part1
{
    internal static object CountAssigmentPairs(string[] lines)
    {
        var assigmentPairsCount = 0;

        foreach (var line in lines)
        {
            var pairs = line.Split(",");
            var firstSection = pairs[0];
            var secondSection = pairs[1];

            if (SectionContainsTheOther(firstSection, secondSection))
            {
                assigmentPairsCount++;
            }
        }

        return assigmentPairsCount;
    }

    private static bool SectionContainsTheOther(string firstSection, string secondSection)
    {
        var firstSectionNumbers = firstSection.ParseSection();
        var secondSectionNumbers = secondSection.ParseSection();

        var firstSectionStart = firstSectionNumbers.Item1;
        var firstSectionEnd = firstSectionNumbers.Item2;

        var secondSectionStart = secondSectionNumbers.Item1;
        var secondSectionEnd = secondSectionNumbers.Item2;


        var firstSectionInsideSecond = firstSectionStart <= secondSectionStart && firstSectionEnd >= secondSectionEnd;
        var secondSectiondInsideFirst = secondSectionStart <= firstSectionStart && secondSectionEnd >= firstSectionEnd;

        return firstSectionInsideSecond || secondSectiondInsideFirst;
    }


}
