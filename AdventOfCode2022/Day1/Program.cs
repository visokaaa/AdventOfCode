using Day1.Solution;
using Day1;
using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var lines = File.ReadAllLines(path);

var elfs = InputParser.ToListOfElfs(lines);

//Part one
var maxElfCalory = Part1.FindMaxCaloriesElf(elfs);
Console.WriteLine($"Max calories: {maxElfCalory}");

//Part two
var caloriesSumOfTop3Elfs = Part2.GetTotalOfTop3(elfs);
Console.WriteLine($"Sum of top 3: {caloriesSumOfTop3Elfs}");