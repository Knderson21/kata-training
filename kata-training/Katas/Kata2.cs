namespace kata_training.Katas;

public class Kata2
{
    /* https://www.codewars.com/kata/526571aae218b8ee490006f4/csharp
    Write a function that takes an integer as input, and returns the number of bits that are equal to one 
    in the binary representation of that number. You can guarantee that input is non-negative.
      
    Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
    */
    
    public static int CountBits(int n)
    {
        string binary = Convert.ToString(n, 2);
        var myArray = binary.ToCharArray();
      
        int result = myArray.Count(x => x == '1');
      
        return result;
    }
    
    // alternate solution:
    public static int CountBits2(int n)
    {
        return Convert.ToString(n, 2).Count(x => x == '1');
    }
}