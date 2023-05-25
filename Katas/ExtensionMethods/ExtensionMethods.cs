using System.Collections;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;

namespace Katas.ExtensionMethods;

public static class ExtensionMethods
{
    public static Object Next(this LinkedList<int> list) 
    {
        return new Object();
    }
    
    // "hello WORLD".ToAlternatingCase() == "HELLO world"
    public static string ToAlternatingCase (this string s) => new string(
            s.Select(c => char.IsLower(c) ? 
                char.ToUpper(c) : char.ToLower(c)).ToArray());
    
}