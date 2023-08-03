namespace Leetcode.Solutions;

public class ConvertAnArrayIntoA2DArrayWithConditions2610
{
    public static IList<IList<int>> FindMatrix(int[] nums)
    {
        var result = new List<IList<int>>();
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
                continue;
            }

            dict.Add(num, 1);
        }

        while (dict.Count > 0)
        {
            var row = new List<int>();

            foreach (var dictItem in dict)
            {
                row.Add(dictItem.Key);
                dict[dictItem.Key]--;

                if (dict[dictItem.Key] == 0)
                {
                    dict.Remove(dictItem.Key);
                }
            }

            result.Add(row);
        }

        return result;
    }
}