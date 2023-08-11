namespace Leetcode.Solutions;

public class GroupAnagrams49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var answer = new List<IList<string>>();
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var sortedStr = new string(str.OrderBy(c => c).ToArray());

            if (dict.ContainsKey(sortedStr))
            {
                dict[sortedStr].Add(str);
                continue;
            }

            dict.Add(sortedStr, new List<string> { str });
        }

        foreach (var item in dict)
        {
            answer.Add(item.Value);
        }

        return answer;
    }
}