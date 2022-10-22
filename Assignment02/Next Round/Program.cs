string[] firstLine =  Console.ReadLine().Split(" ");

string[] secondLine = Console.ReadLine().Split(" ");

int secondRound = 0;
for(int i=0; i < secondLine.Length; i++)
{
    if (Convert.ToInt32(secondLine[i]) >= Convert.ToInt32(firstLine[1]) && (Convert.ToInt32(secondLine[i]) >0) )
    {
        secondRound += 1;
    }
}

Console.WriteLine(secondRound);