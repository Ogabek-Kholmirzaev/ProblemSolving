namespace Leetcode.Solutions;

public class LongestHarmoniousSubsequence594
{
    public int FindLHS(int[] nums)
    {
        int answer = 0;
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
                continue;
            }
            
            dict.Add(num, 1);
        }

        foreach (var num in nums)
        {
            if(dict.ContainsKey(num + 1))
            {
                answer = Math.Max(answer, dict[num] + dict[num + 1]);
            }
        }

        return answer;
    }
}
