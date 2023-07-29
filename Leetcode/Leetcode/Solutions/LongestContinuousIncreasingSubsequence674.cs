namespace Leetcode.Solutions;

public class LongestContinuousIncreasingSubsequence674
{
    public int FindLengthOfLCIS(int[] nums)
    {
        int max = 1, current = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                current++;
                continue;
            }

            max = Math.Max(max, current);
            current = 1;
        }

        return Math.Max(max, current);
    }
}
