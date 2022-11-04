// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using FatTree;

Console.WriteLine("Enter K!");
var k = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Processing...");

var fatTree = new FatTreeDataCenter(k);
var links = fatTree.GetLinks().ToList();
var count = links.Count();

Console.Write($"There are {count} results. Do you want to print it on Console? (y/N): ");
var input = Console.ReadKey();
Console.WriteLine();

if (input.Key == ConsoleKey.Y)
{
    for (var i = 0; i < links.Count; i++)
    {
        Console.WriteLine(i + 1 + ":\t" + links[i].Node_1 + "\t" + links[i].Node_2);
    }
}
else
{
    Console.WriteLine("Making file...");
    var lines = links.Select((x, i) => $"{i + 1}:\t{x.Node_1}\t{x.Node_2}").ToList();
    var fileName = $"k{k}-links.txt";
    File.WriteAllLines(fileName, lines);
    Process.Start("notepad.exe", fileName);
}
Console.Read();