// LeetCode
Console.WriteLine(NumberOfSteps(14));
int NumberOfSteps(int num)
{
    int steps = 0;

    while (num > 0)
    {
        if (num % 2 == 0)
        {
            num /= 2;  
        }
        else
        {
            num -= 1;
        }

        steps++;
    }
    return steps;
}

int NumberOfStepsBti(int num)
{
    int steps = 0;
    
    while (num > 0)
    {
        if ((num & 1) == 0)
        {
            //num /= 2;
            num >>= 1;
        }
        else
        {
            num -= 1;
        }

        steps++;
    }
    return steps;
}