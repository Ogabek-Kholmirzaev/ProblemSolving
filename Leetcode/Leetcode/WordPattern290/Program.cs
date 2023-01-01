bool WordPattern(string pattern, string s)
{
    var dict = new Dictionary<char, string>();
    var words = s.Split(' ').ToList();

    if(words.Count != pattern.Length) 
        return false;

    for (var i = 0; i < words.Count; i++)
    {
        var word = words[i];
        var _pattern = pattern[i];

        if (dict.ContainsValue(word) && _pattern != dict.First(d => d.Value == word).Key)
            return false;

        if (dict.ContainsKey(_pattern))
        {
            if (dict[_pattern] != word)
                return false;
        }
        else
        {
            dict.Add(_pattern, word);
        }
    }

    return true;
}

Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
Console.WriteLine(WordPattern("aaaa", "dog cat cat dog"));
Console.WriteLine(WordPattern("abba", "dog dog dog dog"));