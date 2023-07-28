using System.Text;

namespace Leetcode.Solutions;

public class LargestPalindromicNumber2384
{
    public static string LargestPalindromic(string num)
    {
        var dict = new Dictionary<char, int>();
        var answer = new StringBuilder();
        int zeroCount = 0;
        string oddNumberString = string.Empty;

        foreach (var item in num)
        {
            if (dict.ContainsKey(item))
                dict[item]++;
            else
                dict.Add(item, 1);
        }

        foreach (var item in dict)
        {
            if (item.Key == '0')
                zeroCount = item.Value;

            if(item.Key != '0')
            {
                for (int i = 0; i < item.Value / 2; i++)
                    answer.Append(item.Key);
            }

            if (item.Value % 2 == 1)
            {
                if (string.IsNullOrWhiteSpace(oddNumberString) == true)
                { 
                    oddNumberString = item.Key.ToString();
                    continue;
                }

                if (oddNumberString[0] < item.Key)
                    oddNumberString = item.Key.ToString();
            }
        }

        if (answer.Length != 0)
        {
            for (int i = 0; i < zeroCount / 2; i++)
                answer.Append('0');
        }

        var result = ReversedSortedString(answer.ToString()) + oddNumberString + SortedString(answer.ToString());

        return string.IsNullOrWhiteSpace(result) ? "0" : result;
    }

    public static string SortedString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Sort(charArray);
        return new string(charArray);
    }

    public static string ReversedSortedString(string s)
    {
        char[] charArray = SortedString(s).ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
