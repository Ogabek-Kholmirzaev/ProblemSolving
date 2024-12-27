namespace Leetcode.Daily;

public class TargetSum
{
    private int ans = 0;

    public int FindTargetSumWays(int[] nums, int target)
    {
        Calc(nums, target, 0, 0);

        return ans;
    }

    private void Calc(int[] nums, int target, int sum, int index)
    {
        if (index == nums.Length)
        {
            if (sum == target)
            {
                ans++;
            }
        }
        else
        {
            Calc(nums, target, sum + nums[index], index + 1);
            Calc(nums, target, sum - nums[index], index + 1);
        }
    }
}
