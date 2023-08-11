using System.Text;

namespace Leetcode.Solutions;

public class EvaluateBracketPairsOfAString1807
{
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var answer = new StringBuilder();
        var dict = new Dictionary<string, string>();
        var isOpenBracket = false;
        var wordBetweenBrackets = new StringBuilder();

        foreach (var item in knowledge)
        {
            dict.Add(item[0], item[1]);
        }

        foreach (var item in s)
        {
            if (item == '(')
            {
                isOpenBracket = true;
                continue;
            }

            if (item == ')')
            {
                answer.Append(dict.ContainsKey(wordBetweenBrackets.ToString()) ? dict[wordBetweenBrackets.ToString()] : "?");
                isOpenBracket = false;
                wordBetweenBrackets.Clear();
                continue;
            }

            if (isOpenBracket)
            {
                wordBetweenBrackets.Append(item);
                continue;
            }

            answer.Append(item);
        }

        return new string(answer.ToString());
    }
}