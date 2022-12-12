using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var text = File.ReadAllText(path);

//Part one
Console.WriteLine(FindStartOfPacketMarker(text, 4));

//Part two
Console.WriteLine(FindStartOfPacketMarker(text, 14));



int FindStartOfPacketMarker(string text, int characterSize)
{
    var characters = text.ToCharArray();
    for (int i = 0; i < characters.Length - characterSize; i++)
    {
        var nextFourChars = text.Substring(i, characterSize);

        if (nextFourChars.Distinct().Count() < characterSize)
        {
            continue;
        }

        return  i + characterSize;
    }

    return -1;
}

