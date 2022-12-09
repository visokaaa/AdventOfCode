using Day5.Models;

namespace Day5;

internal class InputParser
{
    internal static List<CargoCommand> ToCargoCommands(string commandsText)
    {
        var commands = commandsText.Split("\r\n");
        var cargoCommands = new List<CargoCommand>();
        foreach (var command in commands)
        {
            var commandValues = command.Split(" ");
            cargoCommands.Add(new CargoCommand
            {
                 Ammount = int.Parse(commandValues[1]),
                 FromStack = int.Parse(commandValues[3]),
                 ToStack = int.Parse(commandValues[5]),
            });
        }

        return cargoCommands;
    }

    internal static Dictionary<int, Stack<char>> ToCrateStacks(string stackText)
    {
        
        var rows = stackText.Split("\r\n");

        var stacks = IntializeStacks(rows);
        LoadStacks(stacks, rows);
        ReverseStackValues(stacks);

        return stacks;
    }

    private static Dictionary<int, Stack<char>> IntializeStacks(string[] rows)
    {
        var lastRow = rows.Last();
        var stacksCount = char.GetNumericValue(lastRow[lastRow.Length - 2]);
        var stacks = new Dictionary<int, Stack<char>>();
        for (int i = 0; i < stacksCount; i++)
        {
            stacks.Add(i + 1, new Stack<char>());
        }

        return stacks;
    }

    private static void LoadStacks(Dictionary<int, Stack<char>> stacks, string[] rows)
    {
        var crateIndex = 4;

        for (int i = 0; i < rows.Length - 1; i++)
        {
            var stackIndex = 0;
            for (int j = 1; j < rows[i].Length - 1; j += crateIndex)
            {
                var crate = rows[i][j];
                ++stackIndex;

                if (char.IsWhiteSpace(crate))
                {
                    continue;
                }

                stacks[stackIndex].Push(crate);
            }
        }
    }

    private static void ReverseStackValues(Dictionary<int, Stack<char>> stacks)
    {
        for (int i = 0; i < stacks.Count; i++)
        {
            stacks[i + 1].Reverse();
            stacks[i + 1] = new Stack<char>(stacks[i + 1]);
        }
    }
}
