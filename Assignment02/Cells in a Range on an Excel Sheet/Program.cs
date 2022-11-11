// LeetCode
using System.Collections;

string s = "A1:F1";

IList<string> ans = CellsInRange(s);
IList<string> CellsInRange(string s)
{
    char[] str = s.ToCharArray();

    
    List<string> result = new List<string>();

    char col1 = str[0];
    char col2 = str[3];
    char row1 = str[1];
    char row2 = str[4];

    for (char i = col1; i <= col2; i++)
    {
        for (char j = row1; j <= row2; j++)
        {
            result.Add(i.ToString() + j.ToString());
            Console.WriteLine(i.ToString() + j.ToString());
        }
    }


    return result;
}