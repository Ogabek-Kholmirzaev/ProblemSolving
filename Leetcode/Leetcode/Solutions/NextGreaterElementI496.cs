namespace Leetcode.Solutions;

public class NextGreaterElementI496
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums2.Length; i++)
        {
            dict.Add(nums2[i], i);
        }

        for (var i = 0; i < nums1.Length; i++)
        {
            var num = -1;

            for (var j = dict[nums1[i]] + 1; j < nums2.Length; j++)
            {
                if (nums2[j] > nums1[i])
                {
                    num = nums2[j];
                    break;
                }
            }

            nums1[i] = num;
        }

        return nums1;
    }
}