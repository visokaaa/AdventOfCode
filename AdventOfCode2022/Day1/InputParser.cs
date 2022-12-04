using Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1;

internal static class InputParser
{
    public static IEnumerable<Elf> ToListOfElfs(string[] lines)
    {
        var elfs = new List<Elf>();
        var tempElf = new Elf();
        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                elfs.Add(new Elf { Calories = tempElf.Calories });
                tempElf = new Elf();
            }
            else
            {
                tempElf.Calories.Add(int.Parse(line));
            }
        }

        return elfs;
    }
}
