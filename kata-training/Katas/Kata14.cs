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
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char x in str)
        {
            var y = x;

            if (Char.IsLetter(y))
            {
                y = Char.ToLower(y);
            }

            if (!dict.ContainsKey(y))
            {
                dict.Add(y, 1);
            }
            else
            {
                dict[y]++;
            }
        }

        return dict.Count(x => x.Value > 1);
    }
}