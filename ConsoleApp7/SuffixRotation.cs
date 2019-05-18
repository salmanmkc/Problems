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

class SuffixRotation
{
    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();
            MoveArrayCopy(s);

        }
    }

    private static void MoveArrayCopy(string s)
    {
        char[] s3 = new char[s.Length];
        char[] c = s.ToCharArray();
        string s2 = null;
        Array.Copy(c, 0, s3, 3, s.Length);
        foreach(char c2 in s3)
        {
            Console.WriteLine(c2);
        }
    }

    //private static int MoveOld(string s)
    //{
    //    bool ordered = false;
    //    int count = 0;
    //    while (ordered == false)
    //    {
    //        StringBuilder first = new StringBuilder();
    //        for (int strItr = 0; strItr < s.Length - 1; strItr++)
    //        {
    //            first.Append(s[strItr + 1]);
    //        }
    //        first.Append(s[0]);
    //        string firstcompilled = first.ToString();
    //        //Console.WriteLine(firstcompilled);
    //        StringBuilder second = new StringBuilder();
    //        for (int strItr = 0; strItr < s.Length - 1; strItr++)
    //        {

    //            second.Append(firstcompilled[strItr + 1]);
    //        }
    //        second.Append(firstcompilled[0]);
    //        string secondcompilled = second.ToString();
    //        //Console.WriteLine(secondcompilled);
    //        StringBuilder third = new StringBuilder();
    //        for (int strItr = 0; strItr < s.Length - 1; strItr++)
    //        {

    //            third.Append(secondcompilled[strItr + 1]);
    //        }
    //        third.Append(secondcompilled[0]);
    //        string OneMove = third.ToString();
    //        //Console.WriteLine(OneMove);

    //        char prev = OneMove[0];
    //        bool allordered = false;
    //        foreach (char c in OneMove)
    //        {
    //            if (c < prev)
    //            {
    //                allordered = false;
    //                break;
    //            }
    //            else
    //            {
    //                allordered = true;
    //                prev = c;
    //            }
    //        }
    //        if (allordered == false)
    //        {
    //            count++;
    //            Move(OneMove);
    //        }
    //        else
    //        {
    //            ordered = true;
    //            break;
    //        }
    //    }
    //    return count;

    //}
}
