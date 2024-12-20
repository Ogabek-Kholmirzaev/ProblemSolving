using Leetcode.Models;

namespace Leetcode.Daily;

public class ReversOddLevelsOfBinaryTree
{
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        dfs(root.left, root.right, 1);

        return root;
    }

    private void dfs(TreeNode left, TreeNode right, int level)
    {
        if (left == null || right == null)
        {
            return;
        }

        if (level % 2 == 1)
        {
            int temp = left.val;

            left.val = right.val;
            right.val = temp;
        }

        dfs(left.left, right.right, level + 1);
        dfs(left.right, right.left, level + 1);
    }
}
