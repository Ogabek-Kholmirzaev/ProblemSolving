namespace Leetcode.Solutions;

public class BaseballGame682
{
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();

        foreach (var operation in operations)
        {
            if (operation == "+")
            {
                var top = stack.Pop();
                var newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
            }
            else if (operation == "D")
            {
                stack.Push(stack.Peek() * 2);
            }
            else if (operation == "C")
            {
                stack.Pop();
            }
            else
            {
                stack.Push(int.Parse(operation));
            }
        }

        return stack.Sum();
    }
}