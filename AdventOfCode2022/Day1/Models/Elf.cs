using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Models;

internal class Elf
{
    public List<int> Calories { get; set; } = new List<int>();
    public int CaloriesSum { get => Calories.Sum(); }
}
