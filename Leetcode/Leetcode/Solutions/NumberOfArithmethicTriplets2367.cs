namespace Leetcode.Solutions;

public class NumberOfArithmethicTriplets2367
{
    /// <summary>
    /// 2367. Number of Arithmetic Triplets => Leetcode
    /// </summary>
    /// <param name="nums">Strictly increasing integer array</param>
    /// <param name="diff"></param>
    /// <returns></returns>
    public static int ArithmeticTriplets(int[] nums, int diff)
    {
        var cnt = 0;
        var dict = new Dictionary<int, bool>();

        foreach (var num in nums)
        {
            dict.Add(num, true);
        }

        foreach (var dictItem in dict)
        {
            if (dict.ContainsKey(dictItem.Key + 2 * diff) && dict.ContainsKey(dictItem.Key + diff))
            {
                cnt++;
            }
        }

        return cnt;
    }
}