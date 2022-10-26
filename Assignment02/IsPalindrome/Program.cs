//Leet Code

bool IsPalindrome(int x)
{
    int reverseX = 0;
    int temp = x;
    while (temp > 0)
    {
        reverseX = reverseX * 10 + temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine(reverseX);
    return x == reverseX;
}