namespace Day3;

internal static  class CharExtensions
{
    public static int PriorityNumber(this char commonChar)
    {
        return char.IsLower(commonChar) ? commonChar - 96 : commonChar - 38;
    }
}
