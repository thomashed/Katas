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
}