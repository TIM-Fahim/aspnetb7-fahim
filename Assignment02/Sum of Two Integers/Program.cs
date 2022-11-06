//Leet Code
int sum = GetSum(-2, 2);

Console.WriteLine(sum);

int GetSum(int a, int b)
{

    if (a < 0 && b < 0)
    {
        int i = 0;
        
        while (a<0 && b<0) 
        {
            a++;
            b--;
        }
        return b;
    }
    else if (a > 0 && b > 0)
    {
        while (a > 0 && b > 0)
        {
            a--;
            b++;
        }
        return b;
    }
    else if (a > 0 && b < 0)
    {
        while (a > 0 && b < 0)
        {
            a--;
            b++;
        }
        return b;
    }
    else if (a < 0 && b > 0)
    {
        while (a < 0 && b > 0)
        {
            a++;
            b--;
        }
        return b;
    }
    else
    {
        if (a == 0)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
    
}
