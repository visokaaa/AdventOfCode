namespace Day5.Models;

internal class CargoCrane
{
    private Dictionary<int, Stack<char>> crateStacks;
    private List<CargoCommand> commands;

    public CargoCrane(Dictionary<int, Stack<char>> crateStacks, List<CargoCommand> commands)
    {
        this.crateStacks = crateStacks;
        this.commands = commands;
    }

    public Dictionary<int, Stack<char>> CrateStacks { get => crateStacks; }
    public List<CargoCommand> Commands { get => commands; }

    internal void MoveCrates(bool sameOrder)
    {
        foreach (var cargoCommand in Commands)
        {
            if (sameOrder)
            {
                MoveCratesInSameOrder(cargoCommand);
            }
            else
            {
                MoveCrates(cargoCommand);
            }
        }
    }

    private void MoveCrates(CargoCommand cargoCommand)
    {
        var fromStack = crateStacks[cargoCommand.FromStack];
        var toStack = crateStacks[cargoCommand.ToStack];

        for (int i = 0; i < cargoCommand.Ammount; i++)
        {
            toStack.Push(fromStack.Pop());
        }
    }

    private void MoveCratesInSameOrder(CargoCommand cargoCommand)
    {
        var fromStack = crateStacks[cargoCommand.FromStack];
        var toStack = crateStacks[cargoCommand.ToStack];

        var crates = new List<char>();
        for (int i = 0; i < cargoCommand.Ammount; i++)
        {

            crates.Add(fromStack.Pop());
        }

        for (int i = crates.Count; i > 0; i--)
        {
            toStack.Push(crates[i - 1]);
        }
    }

    internal string GetCratesOnTopOfStacks()
    {
        var crates = string.Empty;
        foreach (var stack in crateStacks.Values)
        {
            crates += stack.Pop();
        }

        return crates;
    }
}
