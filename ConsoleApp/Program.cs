// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text;
using FatTree;

Console.WriteLine("Enter K!");
var k = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Processing...");

var fatTree = new FatTreeDataCenter(k);
var links = fatTree.GetLinks().ToList();
var hosts = fatTree.GetHosts().ToList();
var edgeSwitches = fatTree.GetEdgeSwitches().ToList();
var aggregateSwitches = fatTree.GetAggregateSwitches().ToList();
var coreSwitches = fatTree.GetCoreSwitches().ToList();

Console.WriteLine();


Console.WriteLine("Making file...");

var lines = new StringBuilder();
lines.Append("host");
hosts.ForEach(x => lines.Append($"\nh{x.Id},{x.IP.ToString()}"));

lines.Append("\nedge");
edgeSwitches.ForEach(x => lines.Append($"\nes{x.Id},{x.IP.ToString()}"));

lines.Append("\naggr");
aggregateSwitches.ForEach(x => lines.Append($"\nas{x.Id},{x.IP.ToString()}"));

lines.Append("\ncore");
coreSwitches.ForEach(x => lines.Append($"\ncs{x.Id},{x.IP.ToString()}"));

lines.Append("\nlinks");
links.ForEach(x => lines.Append($"\n{x.Node_1},{x.Node_2}"));

var fileName = "fat-tree-topology.txt";
File.WriteAllText(fileName, lines.ToString());
Process.Start("notepad.exe", fileName);

