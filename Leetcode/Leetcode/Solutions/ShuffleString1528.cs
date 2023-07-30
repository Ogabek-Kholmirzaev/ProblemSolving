using System.Text;

namespace Leetcode.Solutions;

public class ShuffleString1528
{
    public static string RestoreString(string s, int[] indices)
    {
        var result = new StringBuilder(s);

        for (int i = 0; i < s.Length; i++)
        {
            result[indices[i]] = s[i];
        }

        return result.ToString();
    }
}