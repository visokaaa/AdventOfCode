// See https://aka.ms/new-console-template for more information
using Day2.Solution;
using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var lines = File.ReadAllLines(path);

//Part one
var totalScoreP1 = Part1.CalculateTotalScore(lines);
Console.WriteLine(totalScoreP1);

//Part two
var totalScoreP2 = Part2.CalculateTotalScore(lines);
Console.WriteLine(totalScoreP2);
