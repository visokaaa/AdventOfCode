// See https://aka.ms/new-console-template for more information
using Day4;
using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var lines = File.ReadAllLines(path);

//Part one
var assigmentPairsCount = Part1.CountAssigmentPairs(lines);
Console.WriteLine(assigmentPairsCount);

//Part two
var touchedPairsCount = Part2.CountTouchedPairs(lines);
Console.WriteLine(touchedPairsCount);