
int Reverse(int x)
{
    int overflow = int.MaxValue / 10;
    
    int reserver = 0;
    bool isMinus = false;
    if (x < 0)
    {
        isMinus = true;
        x*= -1;
    }

    while (x > 0)
    {
       if (reserver > overflow)
        {
            return 0;
        }
        int tmp = x % 10;
        reserver = reserver * 10 + tmp;
        x /= 10;
    }

    if (isMinus)
    {
        reserver *= -1;
    }

    return reserver;
}


Console.WriteLine(Reverse(1534236469));
