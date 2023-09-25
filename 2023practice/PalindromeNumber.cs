using System.Diagnostics;

namespace _2023practice;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
         int r = 0, c = x;
        while (c > 0)
        {
            r = r * 10 + c % 10;
            c /= 10;
        }
        return r == x; 
    }
}