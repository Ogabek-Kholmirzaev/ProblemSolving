namespace Leetcode.Solutions;

public class LongestPalindrome409
{
    public static int LongestPalindrome(string s)
    {
        int result = 0;
        bool hasOdd = false;
        var dict = new Dictionary<char, int>();

        foreach (var item in s)
        {
            if(dict.ContainsKey(item))
                dict[item]++;
            else
                dict.Add(item, 1);
        }

        foreach (var item in dict)
        {
            if(item.Value % 2 == 1)
                hasOdd = true;

            result += item.Value / 2 * 2;
        }

        return hasOdd ? ++result : result;
    }
}
