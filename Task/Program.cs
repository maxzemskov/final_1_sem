Console.Write("Введите массив: ");
string[] input = Console.ReadLine().Split(" ");
int i = 0;
string[] final = new string[input.Length];
int j = 0;
while (i < input.Length)
{
    if (input[i].Length < 4)
    {
        final[j] = input[i];
        i++;
        j++;
    }
    else
    {
        i++;
    }
    }
Console.Write("Output: ");
Console.WriteLine(string.Join(" ", final));