/*
DESCRIPTION:

Count the number of Duplicates

Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example

"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2  # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1  # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2  # 'a' and '1'
"ABBA" -> 2  # 'A' and 'B' each occur twice

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