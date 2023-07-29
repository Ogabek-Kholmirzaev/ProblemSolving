namespace Leetcode.Solutions;

public class MaxConsecutiveOnes485
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int result = 0;
        int current = 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                current++;
                continue;
            }

            result = Math.Max(result, current);
            current = 0;
        }

        return Math.Max(result, current);
    }
}
