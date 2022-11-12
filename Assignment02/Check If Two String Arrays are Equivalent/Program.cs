// LeetCode

string[] w1 = { "ab", "c" }; string[] w2 = { "a", "bc" };
Console.WriteLine(ArrayStringsAreEqual(w1,w2));
bool ArrayStringsAreEqual(string[] word1, string[] word2)
{
    bool ans = true;

    string s1 = string.Join("", word1);
    Console.WriteLine(s1);
    
    string s2 = string.Join("", word2);

    Console.WriteLine(s2);
    if(s1==s2)
    {
        ans = true;
    }
    else
    {
        ans = false;
    }
    return ans;
}
