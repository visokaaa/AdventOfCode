using Day8.Solution;
using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var lines = File.ReadAllLines(path);

//Part one
Console.WriteLine(Part1.NumberOfVisibleTrees(lines));

//Part two
Console.WriteLine(Part2.ScenicScore(lines));

