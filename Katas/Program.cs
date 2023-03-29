// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Katas;

var katas = new KatasOne("KatasOne");

Console.WriteLine("Katas Go!"); 
Console.WriteLine("-----------------------");
Console.WriteLine(katas.Message);

Console.WriteLine("--------------------- KatasOne.Alphanumeric ---------------------");

Console.WriteLine("expect false: " + KatasOne.Alphanumeric(""));
Console.WriteLine("expect false: " + KatasOne.Alphanumeric("¤¤##"));
Console.WriteLine("expect true: " + KatasOne.Alphanumeric("test"));
Console.WriteLine("expect true: " + KatasOne.Alphanumeric("test987654"));
Console.WriteLine("expect true: " + KatasOne.Alphanumeric("Mazinkaiser"));
Console.WriteLine("expect false: " + KatasOne.Alphanumeric("hello world_"));
Console.WriteLine("expect true: " + KatasOne.Alphanumeric("PassW0rd"));
Console.WriteLine("expect false: " + KatasOne.Alphanumeric("     "));
