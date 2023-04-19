using System.Collections;
using System.Globalization;
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

    public static int SumTwoSmallestNumbers(int[] numbers) => numbers.OrderBy(i => i).Take(2).Sum();
    
    
}