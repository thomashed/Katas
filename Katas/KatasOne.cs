using System.Collections;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text.RegularExpressions;
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
    
    public static string AbbrevName3(string name)=> string.Join(".", name.Split(' ').Select(s => s[0])).ToUpper();
    
    public static int DuplicateCount3(string str) => str
            .GroupBy(char.ToLower)
            .Count(chars => chars.Count() > 1);
    
    // FIND THE LOCH NESS MONSTER. SAVE YOUR TREE FIDDY
    public static bool IsLockNessMonster(string sentence) => 
        new[]{"tree fiddy","3.50","three fifty"}.Count(sentence.ToLower().Contains) > 0;
 
    
    // "ab","AB"     -> true
    public static bool IsOpposite2(string s1, string s2) => 
        !string.IsNullOrEmpty(s1) && 
        s1.SequenceEqual(s2.Select(
            c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
    
    // second_symbol('Hello world!!!','l') --> 3
    // second_symbol('Hello world!!!', 'A') --> -1
    public static int SecondSymbol2(string str, char symbol)
    {
        var firstOccurrence = str.IndexOf(symbol);
        return str.Length > firstOccurrence ? str.IndexOf(symbol, firstOccurrence + 1) : -1;
    }
    
    public static int SumTwoSmallestNumbers3(int[] numbers) => 
        numbers.OrderBy(i => i).Take(2).Sum();
    
    // [3, 4, 3, 6]
    public static int SumNoDuplicates2(int[] arr) =>
        arr.Sum(i => arr.Count(i1 => i1 == i) == 1 ? i : 0);

    public static IEnumerable<int> GetIntegersFromList2(List<object> listOfItems) =>
        listOfItems.OfType<int>();

    // "ab","AB"     -> true
    public static bool IsOpposite3(string s1, string s2) => !string.IsNullOrEmpty(s1) 
                         && !string.IsNullOrEmpty(s2) 
                         && s1.SequenceEqual(s2.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));

    
    // Sam Harris => S.H
    public static string AbbrevName4(string name) => 
        string.Join(".", name.Split(' ').Select(s => s[0]).ToArray()).ToUpper();
        
    
    // [3, 4, 3, 6] , the function should return 10.
    public static int SumNoDuplicates3(int[] arr) => 
        arr.GroupBy(i => i).Where(ints => 
            ints.Count() == 1).Sum(group => group.Key);
    
    public static int BetweenExtremes2(int[] numbers) => 
        numbers.Length > 0 ? numbers.Max() - numbers.Min() : 0;
    
        // "aBcd","AbCD" -> true
    public static bool IsOpposite4(string s1, string s2) => !string.IsNullOrEmpty(s1) && 
                                                            !string.IsNullOrEmpty(s2) && 
                                                            s1.SequenceEqual(s2.Select(c => 
                                                                char.IsLower(c) ? 
                                                                    char.ToUpper(c) : 
                                                                    char.ToLower(c)));
    
    public static bool Alphanumeric2(string str) => 
        !string.IsNullOrEmpty(str) && 
        str.All(char.IsLetterOrDigit);
    
    // {1, 2, "a", "b"}) => {1, 2}
    public static IEnumerable<int> GetIntegersFromList3(List<object> listOfItems) =>
        listOfItems.OfType<int>();

    // [1, 434, 555, 34, 112] should return 554 (i.e., 555 - 1).
    public static int BetweenExtremes3(int[] numbers) => 
        numbers?.Length > 0 ? numbers.Max() - numbers.Min() : -1;

    // ('Hello world!!!','l') --> 3
    public static int SecondSymbol3(string str, char symbol) => 
        str.IndexOf(symbol, str.IndexOf(symbol) + 1);
 
    // input = ["red", "green", "red", "blue", "blue"] --> 2
    // [Blue, Aqua, Blue, Teal, Blue, Black] --> 1
    public static int NumberOfPairs(string[] gloves)
    {
        var pairs = gloves
            .GroupBy(s => s)
            .Aggregate(0, (i, grouping) => 
                i += grouping.Count() / 2);
        
        return pairs;
    }
    
    public static int NumberOfPairs3(string[] gloves) => 
        gloves
            .GroupBy(s => s)
            .Select(grouping => grouping.Count() / 2)
            .Sum();
    
    public static int GetAverage2(int[] marks) => 
        (int)marks.Average();
    
    // "aBcd","AbCD" -> true
    public static bool IsOpposite5(string s1, string s2)
    {
        return !string.IsNullOrEmpty(s1) && 
               !string.IsNullOrEmpty(s2) && 
               s1.SequenceEqual(
                   s2.Select(c => char.IsLower(c) ? 
                       char.ToUpper(c) : 
                       char.ToLower(c)));
    }
    
    //  {3, 4, 3, 6, 1, 1,3, 9, 2, 10}
    public static int SumIgnoreDuplicates(int[] arr) => 
        arr.GroupBy(i => i)
            .Where(ints => ints.Count() == 1)
            .Select(ints => ints.Key)
            .Sum();
        
    public static int MakeNegative(int number) => 
        -Math.Abs(number);
 
    public static string ToAlternatingCase3(string s) => 
        string.Concat(s.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
 
    //  [19, 5, 42, 2, 77], the output should be 7
    public static int SumTwoSmallestNumbers4(int[] numbers) => 
        numbers.Order().Take(2).Sum();
    
    public static string Replace(string s)
    {
        var vowels = "aeiouAEIOU";
        var sortedForVowels = !string.IsNullOrEmpty(s) ? 
            s.Select(c => vowels.Contains(c) ? '!' : c) : 
            throw new ArgumentException("Invalid argument!");
        
        return string.Concat(sortedForVowels);
    }
    
    public static int SecondSymbolIndex(string str, char symbol)
    {
        var indexHitToSearchFrom = str.IndexOf(symbol) + 1;
        return str.Length > indexHitToSearchFrom ? str.IndexOf(symbol, indexHitToSearchFrom) : -1;
    }
    
    // [1, 434, 555, 34, 112] should return 554 (i.e., 555 - 1).
    public static int DiffExtremes(int[] numbers) => 
        numbers.Max() - numbers.Min();

    // replace("!Hi! Hi!") === "!H!! H!!"
    public static string ReplaceWith(string s, char symbol) =>  
        string.Concat(s.Select(c => "aeiouAEIOU".Contains(c) ? '!' : c));

    // for the list [3, 4, 3, 6] , the function should return 10.
    public static int SumNoUnique(int[] arr) => 
        arr
            .GroupBy(i => i)
            .Sum(ints => ints.Count() == 1 ? ints.Key : 0);
    
    // [19, 5, 42, 2, 77], the output should be 7
    public static int SumTwo(int[] numbers) => 
        numbers
            .Order()
            .Take(2)
            .Sum();

    // input = ["red", "green", "red", "blue", "blue"]
    // result = 2 (1 red pair + 1 blue pair)
    public static int NumberOfGlovePairs(string[] gloves) => gloves
            .GroupBy(s => s)
            .Select(gloves => gloves.Count() / 2)
            .Sum();
    
    // "aBcd","AbCD" -> true
    public static bool IsCharsOpposite(string s1, string s2)
    {
        return !string.IsNullOrEmpty(s1) && 
               !string.IsNullOrEmpty(s2) && 
               s1.SequenceEqual(s2.
                   Select(c => 
                       char.IsUpper(c) ? 
                       char.ToLower(c) : 
                       char.ToUpper(c)));
    }
    
    public static int DuplicateTimes(string str) => str
            .ToLower()
            .GroupBy(c => c)
            .Count(chars => chars.Count() > 1);

    
    
    public static int[] ValidateBet(int N, int M, string text)
    {
        if (text.All(c => char.IsNumber(c) || c is ',' or ' '))
        {
            return text
                .Where(char.IsNumber)
                .Select(c => (int)char.GetNumericValue(c))
                .Order()
                .ToArray();
        }
        
        return null; 
    }
    
    //  "Hey fellow warriors" => returns "Hey wollef sroirraw" 
    // string.Join(".", name.Split(' ').Select(s => s[0]).ToArray()).ToUpper();
    public static string SpinWords(string sentence)
    {
        var revisedSentence = string.Join(' ',sentence.Split(' ').Select(s =>
        {
            if (s.Length >= 5)
            {
                var wordToReverse = s.ToCharArray();
                Array.Reverse(wordToReverse);
                return new string(wordToReverse);    
            }
            else
            {
                return s;
            }
        }));

        return revisedSentence;
    }
    
    // 1,2,2,3,3,3,4,3,3,3,2,2,1 --> 4
    public static int FindOdd(int[] seq) => seq
            .GroupBy(i => i)
            .Single(ints => ints.Count() % 2 != 0)
            .Key;

    // new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    public static string CreatePhoneNumber(int[] numbers)
    {
        var numberAsString = string.Join("", numbers);
        var phoneNumber = 
            $"({numberAsString.Substring(0,3)}) " +
            $"{numberAsString.Substring(3,3)}-" +
            $"{numberAsString.Substring(6,4)}";
        
        return phoneNumber;
    }

    // ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
    public static string Likes(string[] name)
    {
        switch (name.Length)
        {
            case 0:
                return "no one likes this";
            case 1:
                return $"{name[0]} likes this";
            case 2:
                return $"{name[0]} and {name[1]} like this";
            case 3:
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            default:
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }
    }
    
    public static string Disemvowel(string str) => new string(str
            .Where(c => !"AEIOUaeiou"
                .Contains(c))
            .ToArray());
    
    public static string HighAndLow(string numbers)
    {
        var orderedNumbers = numbers.Split().Select(int.Parse);
        return new string(orderedNumbers.Max() + " " + orderedNumbers.Min());
    }
    
    public static string GetMiddle(string s) => 
        (s.Length % 2 == 0) ? 
            s.Substring(s.Length / 2 - 1, 2) : 
            s.Substring(s.Length / 2, 1);

    public static String Accum(string s)
    {
        return string
            .Join('-', s
                .Select((letter, i) => 
                    char.ToUpper(letter) + new string(char.ToLower(letter),i)));
    }

    public static bool IsSquare(int n) => 
        Math.Sqrt(n) % 1 == 0;

    // In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". 
    // "ATTGC" --> "TAACG"
    // "GTAT" --> "CATA"
    public static string MakeComplement(string dna)
    {
        return string.Concat(dna.Select(c =>
            {
                switch (c)
                {
                    case 'T':
                        return 'A';
                    case 'A':
                        return 'T';
                    case 'C':
                        return 'G';
                    default:
                        return 'C';
                }
            }));
    }
    
    // isIsogram "Dermatoglyphics" = true
    // isIsogram "moose" = false
    // isIsogram "aba" = false
    public static bool IsIsogram(string str)
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }
    
    public static int DescendingOrder(int num)
    {
        return Int32.Parse(String
            .Join("", num
                .ToString()
                .ToCharArray()
                .OrderByDescending(c => c)));
    }
    
    public static int FindShort(string s) => 
        s.Split(' ').Min(s1 => s1.Length);

    // XO("ooxXm") => true
    // XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
    // XO("zzoo") => false
    public static bool XO(string input)
    {
        var keyChars = new[]{'x','o'};
        var inputLowered = input.ToLower();

        if (!inputLowered.Contains(keyChars[0]) && 
            !inputLowered.Contains(keyChars[1]))
        {
            return true;
        }

        var keyCharsGrouped = inputLowered
            .Where(keyChars.Contains)
            .GroupBy(c => c);

        Console.WriteLine("---> test: " + keyCharsGrouped.Count());
        
        return keyCharsGrouped.Count() > 1 && 
               keyCharsGrouped.First().Count() == keyCharsGrouped.Last().Count();
    }
    
    // Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
    // Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
    public static string ToJadenCase(string phrase)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }

    public static int FindShortest(string s) =>
        s.Split(' ').Min(s1 => s1.Length);

    // Kata.Maskify("4556364607935616"); // should return "############5616"
    public static string Maskify(string cc)
    {
        if (cc.Length < 4) return cc;
        var lastFour = cc.Substring(cc.Length - 4);
        var masked = cc.Substring(0, cc.Length - 4).Select(c => '#');
        return string.Join("", masked) + lastFour;
    }
    
    public static int GetSum(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        
        var sum = 0;
        
        for (int i = int.Min(1,b); i <= int.Max(a,b); i++)
        {
            sum += i;
        }

        return sum;
    }
    
    // friend ["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]
    public static IEnumerable<string> FriendOrFoe (string[] names) => 
        names.Where(s => s.Length == 4);
    
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        return data
            .Select(memberInfo => 
                (memberInfo[0] >= 55 && memberInfo[1] > 7) ? 
                    "Senior" : "Open");
    }
    
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str
            .Split(" ")
            .Select(s => new string(s.Reverse().ToArray())));
    }

    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return numbers;
        }
        
        var filteredNumbers = numbers;
        filteredNumbers.Remove(numbers.Min());
        return filteredNumbers;
    }
    
    public static int BreakChocolate(int n, int m) 
    {
        return n * m > 0 ? n * m - 1 : 0;
    }
    
    // coDe
    public static string Solve(string s) => 
        (s.Count(char.IsLower) >= s.Count(char.IsUpper)) ? 
            s.ToLower() : s.ToUpper();
    
    // string s="aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
    // Assert.AreEqual("3/56", Printer.PrinterError(s));
    public static string PrinterError(String s)
    {
        // TODO: we're using the wrong version of Select in this case
        var invalidCharCounter = s.Select((c, i) => !"abcdefghijklm".Contains(c) ? i++ : i);

        foreach (var VARIABLE in invalidCharCounter)
        {
            Console.WriteLine("test --> " + VARIABLE);
        }
        
        return $"{invalidCharCounter.ToArray().Length}/{s.Length}";
    }

}




























