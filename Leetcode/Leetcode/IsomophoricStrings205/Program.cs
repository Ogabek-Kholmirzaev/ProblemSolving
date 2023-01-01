bool IsIsomorphic(string s, string t)
{
    if (s.Length != t.Length) return false;

    var dict = new Dictionary<char, char>();
    var length = s.Length;

    for (var i = 0; i < length; i++)
    {
        var a = s[i];
        var b = t[i];

        if (dict.ContainsValue(b))
        {
            var c = dict.First(d => d.Value == b).Key;

            if(c != a) return false;
        }

        if (dict.ContainsKey(a))
        {
            if (dict[a] != b) return false;
        }
        else
        {
            dict.Add(a, b);
        }
    }

    return true;
}

Console.WriteLine(IsIsomorphic("egg", "add"));
Console.WriteLine(IsIsomorphic("foo", "bar"));
Console.WriteLine(IsIsomorphic("paper", "title"));