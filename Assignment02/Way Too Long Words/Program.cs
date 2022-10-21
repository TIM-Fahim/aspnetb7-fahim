
int numberOfWords = Convert.ToInt32(Console.ReadLine());

string[] words = new string[numberOfWords];

for (int i = 0; i < numberOfWords; i++)
{
    words[i] = Console.ReadLine();
}

foreach (string word in words)
{
    if (word.Length <= 10)
    {
        Console.WriteLine(word);
    }
    //else if (word.Length == 11)
    //{

    //}
    else
    {
        string answer = $"{word[0]}{word.Length - 2}{word[word.Length - 1]}";
        Console.WriteLine(answer);
    }
}


