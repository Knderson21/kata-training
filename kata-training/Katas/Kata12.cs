/*

For simplicity, you'll have to capitalize each word, check out how contractions are expected to be in the example below.

Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

Example:

Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:	 "How Can Mirrors Be Real If Our Eyes Aren't Real"

*/

namespace kata_training.Katas;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class Kata12
{
	public static string ToJadenCase(this string phrase)
  { 
		string[] words = phrase.Split(' ');

		for (int i = 0; i < words.Length; i++)
		{
			if (words[i].Length > 0)
			{
				words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
			}
		}

		return string.Join(" ", words);
  }
  
  //alt solution
  public static string ToJadenCase2(this string phrase)
  {
    return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
  }
  
  //alt solution2
  public static string ToJadenCase3(this string phrase)
  {
    	return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
  }
}