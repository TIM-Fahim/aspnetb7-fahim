//Leet Code


string s = "MCMXCIV";
Dictionary<char, int> d = new Dictionary<char, int>();

d.Add('I', 1);
d.Add('V', 5);
d.Add('X', 10);
d.Add('L', 50);
d.Add('C', 100);
d.Add('D', 500);
d.Add('M', 1000);

int len = s.Length;
char[] SC = s.ToCharArray();
int Rresult = 0;
for (int i = 0; i < len; i++)
{
    if (SC[i] == 'I' && SC[i + 1] == 'V')

    {
        Rresult += 4;
        if (i < s.Length - 1)
        {
            i++;
        }


    }
    else if (SC[i] == 'I' && SC[i + 1] == 'X')
    {
        Rresult += 9;
        if (i < s.Length - 1)
        {
            i++;
        }
    }
    else if (SC[i] == 'X' && SC[i + 1] == 'L')
    {
        Rresult += 40;
        if (i < s.Length - 1)
        {
            i++;
        }
    }
    else if (SC[i] == 'X' && SC[i + 1] == 'C')
    {
        Rresult += 90;
        if (i < s.Length - 1)
        {
            i++;
        }
    }
    else if (SC[i] == 'C' && SC[i + 1] == 'D')
    {
        Rresult += 400;
        if (i < s.Length - 1)
        {
            i++;
        }
    }
    else if (SC[i] == 'C' && SC[i + 1] == 'M')
    {
        Rresult += 900;
        if (i < s.Length - 1)
        {
            i++;
        }
    }
    else
    {
        Rresult += d[SC[i]];
    }

}
Console.WriteLine(Rresult);