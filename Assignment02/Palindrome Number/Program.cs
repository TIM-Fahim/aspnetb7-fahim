bool IsPalindrome(int x)
{
    if (x < 0) return false;
    int reverse = 0;
    int tmp = x;
    while (tmp > 0)
    {
        reverse = reverse * 10 + tmp % 10;
        tmp /= 10;
    }
    return reverse == x;
}

Console.WriteLine(IsPalindrome(-121));