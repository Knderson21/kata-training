namespace kata_training.Katas;

public class Kata5
{
    /*
     A Narcissistic Number (or Armstrong Number) is a positive number which is the sum of its own digits, each 
     raised to the power of the number of digits in a given base. In this Kata, we will restrict ourselves to 
     decimal (base 10).
       
       For example, take 153 (3 digits), which is narcissistic:
       
           1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
       and 1652 (4 digits), which isn't:
       
           1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
       The Challenge:
       
       Your code must return true or false (not 'true' and 'false') depending upon whether the given number is 
       a Narcissistic number in base 10.
       
       This may be True and False in your language, e.g. PHP.
       
       Error checking for text strings or other invalid inputs is not required, only valid positive non-zero integers 
       will be passed into the function.
     */
    
    public static bool Narcissistic(int val)
    {
        // Code me
        int[] digits = val.ToString().Select(c => int.Parse(c.ToString())).ToArray();
    
        int total = 0;
        Array.ForEach(digits, i => total += (int)Math.Pow(i, digits.Length));
    
        return (val == total) ? true : false;
    }
    
    // alternate solution:
    public static bool Narcissistic2(int value)
    {
        var str = value.ToString();
        return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
    }
}