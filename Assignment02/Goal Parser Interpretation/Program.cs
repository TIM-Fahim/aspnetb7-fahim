// LeetCode
Console.WriteLine(Interpret("G()()()()(al)"));
string Interpret(string command)
{
    string ans = "";

    for (int i = 0; i < command.Length; i++)
    {
        if (command[i] == 'G')
        {
            ans += "G";
        }
        else if (command[i] == '(' && command[i + 1] == ')')
        {
            ans += "o";
            i++;
        }
        else
        {
            ans += "al";
            i += 3;
        }
    }
    return ans;
}