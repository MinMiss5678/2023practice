namespace _2023practice;

public class LongestCommonPrefix
{
    public static string LongestCommonPrefix1(string[] ss)
    {
        //比較每筆資料中同個位置的字元是否一樣
        var shortest = ss.OrderBy(s => s.Length).First();

        for (int i = 0; i < shortest.Length; i++)
        {
            if (ss.Select(s => s[i]).Distinct().Count() > 1)
            {
                return shortest[..i];
            }
        }

        return shortest;
    }
}