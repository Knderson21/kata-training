/*
DESCRIPTION:

In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Examples
Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
Notes:
All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.

 */

namespace kata_training.Katas;

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata15
{
    public static string HighAndLow(string numbers)
    {
        string[] nums = numbers.Split(' ');
        List<int> list = new List<int>();

        foreach (string i in nums)
        {
            list.Add(int.Parse(i));
        }

        return list.Max() + " " + list.Min();
    }
}