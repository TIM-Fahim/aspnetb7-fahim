int FirstUniqChar(string s)
{


    Dictionary<char, int> dict = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        if (dict.ContainsKey(s[i]))
        {
            dict[s[i]]++;
        }
        else
        {
            dict.Add(s[i], 1);
        }
    }

    for (int i = 0; i < s.Length; i++)
    {
        if (dict[s[i]] == 1)
        {
            return i;
        }
    }
    return -1;
}