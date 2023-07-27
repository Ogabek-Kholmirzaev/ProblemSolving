namespace Leetcode.Solutions;

public class ValidParentheses20
{
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var bracketsDictionary = new Dictionary<char, char>()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (var item in s)
        {
            if (bracketsDictionary.ContainsValue(item))
            {
                stack.Push(item);
                continue;
            }

            if (stack.Count == 0 || stack.Pop() != bracketsDictionary[item])
                return false;
        }

        return stack.Count == 0;
    }
}