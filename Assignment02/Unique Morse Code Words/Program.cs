// LeetCode
using System.Text;
string[] s = new string[] { "gin", "zen", "gig", "msg" };
Console.WriteLine(UniqueMorseRepresentations(s));
int UniqueMorseRepresentations(string[] words)
{
    string[] codes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

    HashSet<string> set = new HashSet<string>();

    StringBuilder stBuild = new StringBuilder();

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < words[i].Length; j++)
        {
            stBuild.Append(codes[words[i][j] - 'a']); 
        }
        set.Add(stBuild.ToString());
        stBuild.Clear();
    }

    return set.Count;
}