/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

Additionally, if the number is negative, return 0.

Note: If the number is a multiple of both 3 and 5, only count it once.

*/
namespace kata_training.Katas;

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata9
{
    public static int MultiplesOf3Or5(int value)
    {
        if (value <= 5)
        {
            if (value == 5)
            {
                return 8;
            }
            else if (value == 3)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
        
        decimal d = value / 3;
        
        int x = Convert.ToInt32(Math.Floor(d));
        
        List<int> threesList = new List<int>();
        
        List<int> fivesList = new List<int>();
        
        for (int i = 1; i <= x; i++)
        {
            threesList.Add(i * 3);
        }
        
        decimal e = value / 5;
        
        int y = Convert.ToInt32(Math.Floor(e));
        
        for (int i = 1; i <= y; i++)
        {
            fivesList.Add(i * 5);
        }
        
        return threesList.Union(fivesList).Where(z => z != value).Sum();
    }
}