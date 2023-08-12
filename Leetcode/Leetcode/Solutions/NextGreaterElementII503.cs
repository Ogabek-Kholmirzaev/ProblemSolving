namespace Leetcode.Solutions;

public class NextGreaterElementII503
{
    public int[] NextGreaterElements(int[] nums)
    {
        var ans = new int[nums.Length];
        var max = nums.Max();

        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = -1;

            if (nums[i] == max)
            {
                continue;
            }

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    ans[i] = nums[j];
                    break;
                }
            }

            if (ans[i] == -1)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        ans[i] = nums[j];
                        break;
                    }
                }
            }
        }

        return ans;
    }
}