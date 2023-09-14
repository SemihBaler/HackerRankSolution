﻿using System.CodeDom.Compiler;
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
     
Complete the 'plusMinus' function below.*
The function accepts INTEGER_ARRAY arr as parameter.*/

    public static void plusMinus(List<int> arr)
    {
        decimal positive = 0;
        decimal negative = 0;
        decimal zero = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                positive++;
            }
            if (arr[i] < 0)
            {
                negative++;
            }
            if (arr[i] == 0)
            {
                zero++;
            }
        }
        Console.WriteLine(Math.Round(positive / arr.Count, 6));
        Console.WriteLine(Math.Round(negative / arr.Count, 6));
        Console.WriteLine(Math.Round(zero / arr.Count, 6));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
