// LeetCode
string st = "codeleet";
int[] indice = { 4, 5, 6, 7, 0, 2, 1, 3 };

Console.WriteLine(RestoreString(st, indice));

string s = "abc";
int[] indices = { 0, 1, 2 };

Console.WriteLine(RestoreString(s, indices));

string RestoreString(string s, int[] indices)
{
    string ans = "";
    char[] arr = new char[s.Length];
    for (int i = 0; i < indices.Length; i++)
    {
        arr[indices[i]] = s[i];
    }
    ans = new string(arr);
    return ans;
}