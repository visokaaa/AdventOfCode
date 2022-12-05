using Day3.Solution;
using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var lines = File.ReadAllLines(path);

//Part one
var prioritiesSum = Part1.CalculatePrioritiesSum(lines);
Console.WriteLine(prioritiesSum);

//Part two
var prioritiesSum2 = Part2.CalculatePrioritiesSum(lines);
Console.WriteLine(prioritiesSum2);
