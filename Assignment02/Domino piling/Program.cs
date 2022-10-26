string input = Console.ReadLine();

string[] inputArray = input.Split(' ');

int boardSize = int.Parse(inputArray[0]) * int.Parse(inputArray[1]);

Console.WriteLine(boardSize / 2);