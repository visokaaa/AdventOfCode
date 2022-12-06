namespace Day4;

internal static class StringExtensions
{
    public static (int, int) ParseSection(this string section)
    {
        var numbers = section.Split("-");

        return (int.Parse(numbers[0]), int.Parse(numbers[1]));
    }
}
