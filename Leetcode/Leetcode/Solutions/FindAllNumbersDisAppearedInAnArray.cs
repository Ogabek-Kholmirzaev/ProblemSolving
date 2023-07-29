namespace Leetcode.Solutions;

public class FindAllNumbersDisAppearedInAnArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var dict = new Dictionary<int, bool>();
        
        for (var i = 0; i < nums.Length; i++)
            dict.Add(i + 1, false);

        for (var i = 0; i < nums.Length; i++)
            dict[nums[i]] = true;

        return dict.Where(x => x.Value == false).Select(x => x.Key).ToList();
    }
}
