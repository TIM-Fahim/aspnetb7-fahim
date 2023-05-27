void ReverseString(char[] s)
{
    int j = s.Length - 1;
    for (int i = 0; i < s.Length / 2; i++)
    {
        char temp = s[i];
        s[i] = s[j];
        s[j] = temp;
        j--;
    }
}

string s = "hello";
char[] c = s.ToCharArray();
ReverseString(c);

Console.WriteLine(c);
