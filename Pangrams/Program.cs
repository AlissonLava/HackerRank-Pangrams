using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        bool result = true;

        foreach (char a in alphabet)
        {
            bool contains = false;
            foreach (char l in s)
            {
                if (a.ToString() == l.ToString().ToLower())
                {
                    contains = true;
                }
            }

            if (!contains)
            {
                result = false;
                break;
            }
        }

        if (result)
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        Console.WriteLine(result);
    }
}
