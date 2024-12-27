namespace Leetcode.Daily;

public class BestSightseeingPair
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        int res = 0;
        int maxLeft = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            res = Math.Max(res, maxLeft + values[i] - i);
            maxLeft = Math.Max(maxLeft, values[i] + i);
        }

        return res;
    }
}
