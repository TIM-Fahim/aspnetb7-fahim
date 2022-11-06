//Leet Code
string s = "(]";

Console.WriteLine(IsValid(s));

bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        else
        {
            if (stack.Count == 0)
            {
                return false;
            }
            char top = stack.Pop();
            if (c == ')' && top != '(')
            {
                return false;
            }
            if (c == ']' && top != '[')
            {
                return false;
            }
            if (c == '}' && top != '{')
            {
                return false;
            }
        }
    }
    if (stack.Count == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}