using System.Collections;
using System.Runtime.InteropServices.JavaScript;

namespace Katas.ExtensionMethods;

public static class ExtensionMethods
{
    public static Object Next(this LinkedList<int> list) 
    {
        return new Object();
    }
    
    // "hello WORLD".ToAlternatingCase() == "HELLO world"
    public static string ToAlternatingCase (this string s)
    {
        var alternateString = "";
        foreach (var letter in s)
        {
            if (char.IsLower(letter))
            {
                alternateString += char.ToUpper(letter);
            }
            else
            {
                alternateString += char.ToLower(letter);
            }
        }

        return alternateString; 
    }
    
}