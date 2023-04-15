using Katas.ExtensionMethods;

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
        var flippedBinary = binaryArray.Reverse().ToArray();
        var binaryIndexer = new int[]{1,2,4,8,16,32,64,128};
        var binarySum = 0;
        for (int i = 0; i < flippedBinary.Length; i++)
        {
            if (flippedBinary[i] == 1)
            {
                binarySum += binaryIndexer[i];
            }
        }

        return binarySum;
    }
       
    
}