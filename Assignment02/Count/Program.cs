//Leet Code

using System.Text.RegularExpressions;

int Count(string text)
{

    string trimmed = Regex.Replace(text, "[^a-zA-Z]+", " ", RegexOptions.Compiled);

    Console.WriteLine(trimmed);
    char[] chars = text.ToCharArray();
    char splitTo = ' ';

    text.Replace(splitTo, ' ');

    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] < 65 || chars[i] > 90 || chars[i] < 97 || chars[i] > 122)
        {
            chars[i] = ' ';
        }
    }
    string trimmedString = chars.ToString();
    foreach (char i in chars)
    {
        if (i < 65 || i > 90 || i < 97 || i > 122)
        {
            splitTo = i;
            break;
        }
    }
    string spliteToString = splitTo.ToString();

    string[] stringCount = text.Split(" ");
    return stringCount.Length;
    throw new NotImplementedException();
}