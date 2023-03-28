// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Katas;

var katas = new KatasOne("KatasOne");

Console.WriteLine("Katas Go!"); 
Console.WriteLine("-----------------------");
Console.WriteLine(katas.Message);

Console.WriteLine("--------------------- KatasOne.Parse ---------------------");
var parsedValues = KatasOne.Parse2("iiisdoso");
Console.WriteLine(parsedValues.Length);

foreach (int value in parsedValues)
{
    Console.WriteLine($"Value: {value}");
}
