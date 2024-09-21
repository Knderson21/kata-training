/*

 */

namespace kata_training.Katas;

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata14
{
    public static int DuplicateCount(string str)
    {
        List<char> chars = new List<char>();
        int count = 0;

        foreach (char x in str)
        {
            var y = x;

            if (Char.IsLetter(y))
            {
                y = Char.ToLower(y);
            }

            if (!chars.Contains(y))
            {
                chars.Add(y);
            }
            else
            {
                count++;
            }
        }

        return count;
    }
}