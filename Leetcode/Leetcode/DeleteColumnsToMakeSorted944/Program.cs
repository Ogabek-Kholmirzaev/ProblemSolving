using System.Text;

int MinDeletionSize(string[] strs)
{
    var cnt = 0;
    var n = strs.Length;
    var m = strs[0].Length;

    for (var i = 0; i < m; i++)
    {
        var word = new StringBuilder();

        for (var j = 0; j < n; j++)
            word.Append(strs[j][i]);

        var wordCharArray = word.ToString().ToCharArray();

        Array.Sort(wordCharArray);

        if(word.ToString() != new string(wordCharArray))
            cnt++;
    }

    return cnt;
}

Console.WriteLine(MinDeletionSize(new string[] { "cba", "daf", "ghi" }));