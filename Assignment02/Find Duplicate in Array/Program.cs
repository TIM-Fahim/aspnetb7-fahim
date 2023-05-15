int[] input = { 1, 2, 1, 3, 4 };

bool ans = false;

for (int i = 0; i < input.Length; i++)
{
    for (int j = i+1; j < input.Length; j++)
    {
        if (input[j] == input[i])
        {
            ans = true;
            break;
        }
        
    }
    if (ans)
    {
        break;
    }
}
if (ans)
{
    Console.WriteLine("Duplicate Found");
}
else
{
    Console.WriteLine("Not Found");
}