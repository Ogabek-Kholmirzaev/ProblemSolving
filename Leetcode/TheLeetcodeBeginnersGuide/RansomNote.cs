namespace Leetcode.TheLeetcodeBeginnersGuide;

public class RansomNote {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dict = new Dictionary<char, int>();

        foreach (var letter in ransomNote) {
            if (dict.ContainsKey(letter)) {
                dict[letter]++;
                continue;
            }

            dict.Add(letter, 1);
        }
        
        foreach (var letter in magazine) {
            if (dict.ContainsKey(letter)) {
                dict[letter]--;
            }
        }

        return !dict.Any(pair => pair.Value > 0);
    }
}