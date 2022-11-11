// LeetCode

string DecodeMessage(string key, string message)
{
    string ans = "";

    Dictionary<char, char> dict = new Dictionary<char, char>();

    char start = 'a';
    for (int i = 0; i < key.Length; i++)
    {
        if (!dict.ContainsKey(key[i]) && key[i] != ' ')
        {
            dict.Add(key[i], start);
            start++;
        }
    }
    for (int j = 0; j < message.Length; j++)
    {
        if (message[j] == ' ')
        {
            ans += ans + " ";
        }
        else
        {
            ans += ans + GetDicValue(dict, message[j]);
        }
    }

    return ans;
}

char GetDicValue(Dictionary<char, char> dict, char key)
{
    
    foreach (KeyValuePair<char, char> kvp in dict)
    {
        if (kvp.Key == key)
        {
            return kvp.Value;
        }
    }

    return ' ';
}