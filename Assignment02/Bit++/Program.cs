int input = int.Parse(Console.ReadLine());

int x = 0;

for (int i = 0; i < input; i++)
{
    string operation = Console.ReadLine();
    if (operation.Contains("++"))
    {
        x++;
    }
    else
    {
        x--;
    }
}

Console.WriteLine(x);