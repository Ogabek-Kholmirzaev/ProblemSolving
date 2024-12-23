using Leetcode.Models;

namespace Leetcode.Daily;

public class MinimumNumberOfOperationsToSortABinaryTreeBylevel
{
    private readonly Dictionary<int, List<int>> dict = [];

    public int MinimumOperations(TreeNode root)
    {
        int ans = 0;

        Dfs(root, 0);

        foreach (var item in dict)
        {
            ans += MinOperationsCount(item.Value);
        }

        return ans;
    }

    private void Dfs(TreeNode node, int level)
    {
        if (dict.ContainsKey(level))
        {
            dict[level].Add(node.val);
        }
        else
        {
            dict.Add(level, [node.val]);
        }

        if (node.left != null)
        {
            Dfs(node.left, level + 1);
        }

        if (node.right != null)
        {
            Dfs(node.right, level + 1);
        }
    }

    private int MinOperationsCount(List<int> nodeValues)
    {
        var sortedNodeValues = nodeValues.OrderBy(x => x).ToList();
        var dic = new Dictionary<int, int>();
        int cnt = 0;

        for (int i = 0; i < nodeValues.Count; i++)
        {
            dic.Add(nodeValues[i], i);
        }

        for (int i = 0; i < nodeValues.Count; i++)
        {
            if (nodeValues[i] != sortedNodeValues[i])
            {
                cnt++;

                int temp = dic[sortedNodeValues[i]];

                dic[nodeValues[i]] = temp;
                nodeValues[temp] = nodeValues[i];
                nodeValues[i] = sortedNodeValues[i];
            }
        }

        return cnt;
    }
}
