namespace Leetcode.Solutions;

public class RangeSumQueryImmutable303
{
    public class NumArray
    {
        private int[] sums;
        public NumArray(int[] nums)
        {
            this.sums = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                sums[i + 1] = sums[i] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return sums[right + 1] - sums[left];
        }
    }
}