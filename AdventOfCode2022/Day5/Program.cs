using Day5;
using Day5.Models;
using System.Reflection;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var text = File.ReadAllText(path);

var splittedText = text.Split("\r\n\r\n");
var stackText = splittedText[0];
var commandsText = splittedText[1];

var crateStacks = InputParser.ToCrateStacks(stackText);
var cargoCommands = InputParser.ToCargoCommands(commandsText);


var cargoCrane = new CargoCrane(crateStacks, cargoCommands);
var cargoCrane2 = new CargoCrane(crateStacks, cargoCommands);

//Part one
cargoCrane.MoveCrates(false);
var cratesOnTop = cargoCrane.GetCratesOnTopOfStacks();
Console.WriteLine(cratesOnTop);

//Part two
cargoCrane2.MoveCrates(true);
var cratesOnTopInSameOrder = cargoCrane2.GetCratesOnTopOfStacks();
Console.WriteLine(cratesOnTopInSameOrder);



