// LeetCode
string s = "is2 sentence4 This1 a3";

Console.WriteLine(SortSentence(s));
string SortSentence(string s)
{
    string[] words = s.Split(' ');

    string[] sortedWords = new string[words.Length];

    foreach (string word in words)
    {
        int index = int.Parse(word[^1].ToString()) - 1;
        sortedWords[index] = word[..^1];
    }
    string ans = string.Join(" ", sortedWords);
    return ans;
}