using System.Collections;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using Katas.ExtensionMethods;
using Microsoft.VisualBasic;

namespace Katas;

public class KatasOne
{
    public string Message { get; init; }

    public KatasOne(string message)
    {
        Message = message;
    }

    public static int[] Parse(string data)
    {
        var value = 0;
        List<int> output = new List<int>();

        foreach (var command in data.ToCharArray())
        {
            switch (command)
            {
                case 'i':
                    value++;
                    break;
                case 'd':
                    value--;
                    break;
                case 's':
                    value *= value;
                    break;
                case 'o':
                    output.Add(value);
                    break;
            }
        }

        return output.ToArray();
    }

    public static int[] Parse2(string data)
    {
        var totalValue = 0;
        var output = new List<int>();

        Dictionary<char, Action> registeredCommands = new Dictionary<char, Action>
        {
            { 'i', () => totalValue++ },
            { 'd', () => totalValue-- },
            { 's', () => totalValue *= totalValue },
            { 'o', () => output.Add(totalValue) }
        };

        foreach (var command in data)
        {
            registeredCommands[command]();
        }

        return output.ToArray();
    }

    public static bool Alphanumeric(string str)
    {
        return !string.IsNullOrEmpty(str) && str.All(char.IsLetterOrDigit);
    }

    public string[] FindDuplicatePhoneNumbers()
    {
        
        throw new NotImplementedException();
    }
    
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems.OfType<int>();
    }
    
    public static int DuplicateCount(string str)
    {
        var extractedDuplicates = str.ToLowerInvariant()
            .GroupBy(c => c)
            .Where(g => g.Count() > 1);
        return extractedDuplicates.Count();
    }
    
    public static long RowSumOddNumbers(long n)
    {
        return (long)Math.Pow(n, 3);
    }
    
    // Testing: [0, 0, 0, 1] ==> 1
    // Testing: [0, 0, 1, 0] ==> 2
    // Testing: [0, 1, 0, 1] ==> 5
    // Testing: [1, 0, 0, 1] ==> 9
    // Testing: [0, 0, 1, 0] ==> 2
    // Testing: [0, 1, 1, 0] ==> 6
    // Testing: [1, 1, 1, 1] ==> 15
    // Testing: [1, 0, 1, 1] ==> 11
    public static int BinaryArrayToNumber(int[] binaryArray)
    {
        return Convert.ToInt32(string.Join("", binaryArray), 2);
    }

    public static int NumberOfPairs1(string[] gloves)
    {
        var numOfPairs = 0;
        var groupedGloves = gloves
            .GroupBy(gloveType => gloveType);

        foreach (var gloveGroup in groupedGloves)
        {
            numOfPairs += (gloveGroup.Count() / 2);
        }
        
        return numOfPairs;
    }
    public static int NumberOfPairs2(string[] gloves)
    {
        return gloves.GroupBy(s => s).Select(grouping => grouping.Count() / 2).Sum();
    }
    
    public static string AbbrevName(string name) => 
        string.Join('.', name.Split(' ').Select(s => s[0])).ToUpper();
    
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }

    public static int Multiply(int x) => (x % 2) == 0 ? x * 8 : x * 9;
    
    public static int GetAverage(int[] marks) => (int)marks.Average();
    
    public static double Chain(double input, Func<double,double>[] fs) => 
        fs.Aggregate(input, (chainedInput, method) => method(chainedInput));
   
    public static int BetweenExtremes(int[] numbers)
    {
        return numbers.Max() - numbers.Min();
    }
    
    public static int SumNoDuplicates(int[] arr)
    {
        return arr.Sum(i => arr.Count(j => i == j) == 1 ? i : 0);
    }
    
    public static int SumTwoSmallestNumbers(int[] numbers) => numbers.Order().Take(2).Sum();
    
    public static int Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);
    
    public static string ReplaceVowels(string s)
    {
        var vowels = "AEIOUaeiou";
        return new string(s.Select(c => vowels.Contains(c) ? '!' : c).ToArray());
    }

    public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;
    
    public static int SecondSymbol(string str, char symbol)
    {
        var searchIndexStart = str.IndexOf(symbol);
        return (str.Length > searchIndexStart) ? str.IndexOf(symbol, searchIndexStart + 1) : 0;
    }
    
    public static int DuplicateCount2(string str)
    {
        return str.ToLower().GroupBy(c => c).Count(chars => chars.Count() > 1);
    }
    
    public static string ToAlternatingCase (string s)
    {
        var stringAlternateCase = "";
        return s.Aggregate(stringAlternateCase, (string a, char c) => 
            stringAlternateCase += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
    }
    
    public static string ToAlternatingCase2(string s)
    {
        return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
    }
    
    public static int SumTwoSmallestNumbers2(int[] numbers) => numbers.OrderBy(i => i).Take(2).Sum();
    
    public static string SwitchItUp(int number)
    {
        var numbers = new string[]
        {
            "Zero",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine"
        };
        
        if (number >= numbers.Length) throw new ArgumentException($"Invalid argument: {number}");
        
        return numbers[number];
    }
    
    public static int FinalGrade(int exam, int projects)
    {
        var finalGrade = 0;

        if (exam > 90 || projects > 10) finalGrade = 100;
        else if (exam > 75 && projects > 4) finalGrade = 90;
        else if (exam > 50 && projects > 1) finalGrade = 75;

        return finalGrade;
    }
 
    public static string AbbrevName2(string name) => 
        string.Join('.', name.Split(' ').Select(s => s[0])).ToUpper();

    public static float Combat(float health, float damage) => health >= damage ? health - damage : 0;

    public static int EnoughSpace(int cap, int on, int wait) => (cap - on) >= wait ? 0 : wait - (cap - on);
    
    // "aBcd","AbCD" -> true
    // "AB","Ab"     -> false
    public static bool IsOpposite(string s1, string s2) => 
        !string.IsNullOrEmpty(s1) && 
        s1.SequenceEqual(s2.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));
    
}




























