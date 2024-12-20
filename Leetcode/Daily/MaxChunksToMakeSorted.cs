namespace Leetcode.Daily;

public class MaxChunksToMakeSorted
{
    public int MaxChunksToSorted(int[] arr)
    {
        int cnt = 0, sum1 = 0, sum2 = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum1 += arr[i];
            sum2 += i;

            if (sum1 == sum2)
            {
                cnt++;
            }
        }

        return cnt;
    }
}
