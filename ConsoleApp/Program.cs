// See https://aka.ms/new-console-template for more information

using FatTree;

Console.WriteLine("Enter K!");

var fatTree = new FatTreeDataCenter(Convert.ToByte(Console.ReadLine()));
var links = fatTree.GetLinks().ToList();

for (var i = 0; i < links.Count; i++)
{
    Console.WriteLine(i + 1 + ":\t" + links[i].Node_1 + "\t" + links[i].Node_2);
}