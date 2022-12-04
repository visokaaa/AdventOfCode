using Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Solution;

internal class Part2
{
    internal static int GetTotalOfTop3(IEnumerable<Elf> elfs)
    {
        return elfs
            .OrderByDescending(_ => _.CaloriesSum)
            .Take(3).Sum(_ => _.CaloriesSum);

    }
}
