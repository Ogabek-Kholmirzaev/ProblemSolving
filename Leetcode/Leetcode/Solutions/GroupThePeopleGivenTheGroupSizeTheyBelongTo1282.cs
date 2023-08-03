namespace Leetcode.Solutions;

public class GroupThePeopleGivenTheGroupSizeTheyBelongTo1282
{
    public static IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var result = new List<IList<int>>();
        var groupsDict = new Dictionary<int, List<int>>();

        for(int i = 0; i < groupSizes.Length; i++)
        {
            if (!groupsDict.ContainsKey(groupSizes[i]))
            {
                groupsDict.Add(groupSizes[i], new List<int>() { i });
                continue;
            }

            groupsDict[groupSizes[i]].Add(i);
        }

        foreach(var group in groupsDict)
        {
            var groupSize = group.Key;
            var groupMembers = group.Value;

            for(int i = 0; i < groupMembers.Count; i += groupSize)
            {
                result.Add(groupMembers.GetRange(i, groupSize));
            }
        }

        return result;
    }
}