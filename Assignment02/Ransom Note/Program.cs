// LeetCode

bool CanConstruct(string ransomNote, string magazine)
{
    var dict = new Dictionary<char, int>();
    foreach (var c in magazine)
    {
        if (dict.ContainsKey(c))
        {
            dict[c]++;
        }

        else
        {
            dict.Add(c, 1);
        }
    }

    foreach (var c in ransomNote)
    {
        if (dict.ContainsKey(c))
        {
            dict[c]--;
            if (dict[c] == 0)
            {
                dict.Remove(c);
            }
        }
        else
        {
            return false;
        }
    }

    return true;
}