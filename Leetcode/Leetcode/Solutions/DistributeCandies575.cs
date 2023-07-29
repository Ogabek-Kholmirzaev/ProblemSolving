using System.Security.Cryptography.X509Certificates;

namespace Leetcode.Solutions;

public class DistributeCandies575
{
    public int DistributeCandies(int[] candyType)
    {
        var dict = new Dictionary<int, bool>();

        foreach (var candy in candyType)
        {
            if (!dict.ContainsKey(candy))
            {
                dict.Add(candy, true);
            }
        }

        return Math.Min(dict.Count, candyType.Length / 2);
    }
}
