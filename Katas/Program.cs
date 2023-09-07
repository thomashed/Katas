// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Threading.Channels;
using Katas;
using Katas.ExtensionMethods;

var katas = new KatasOne("KatasOne");

Console.WriteLine("Katas Go!"); 
Console.WriteLine("-----------------------");
Console.WriteLine(katas.Message);

Console.WriteLine("--------------------- KatasOne.GetIntegersFromList ---------------------");

// Console.WriteLine("Duplicates: " + KatasOne.DuplicateCount("aabbcde"));
var nums = new[]{3, 4, 3, 6, 1, 1,3, 9, 2, 10};
var nums2 = new[] {3, 4, 3, 6};
var nums3 = new List<object>(){1,2,3,"aef","aesf","de"};
var nums4 = new[]{1, 434, 555, 34, 112};
var nums5 = new[]{19, 5, 42, 2, 77};

var gloves = new string[]{"red", "green", "red", "blue", "blue", "black", "black", "gray", "purple", "gray"};
var gloves2 = new string[]{"red", "green", "red", "blue", "blue"};

var string1 = "ab";
var string2 = "PassW0rd";
var items = new List<object>() {"bla","bla",3,4,5,"bla"};

var arg1 = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
var arg2 = "Welcome";
var arg3 = new[] {1,2,3,4,5};
var arg4 = 942;

var test = KatasOne.ToCamelCase("The_Stealth-Warrior");

Console.WriteLine("Program Expects: " + "Thi1s is2 3a T4est");
Console.WriteLine("Program got: " + test);

// foreach (var name in test)
// {
//     Console.Write(name);
// }







