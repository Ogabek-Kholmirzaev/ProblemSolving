namespace Leetcode.TheLeetcodeBeginnersGuide;

public class RunningSumOf1DArray {
    public int[] RunningSum(int[] nums) {
        for (int i = 1; i < nums.Length; i++) {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}