// Написать программу, которая из имеющегося массива строк формирует
// массив строк, длина которых меньше или равна 3 символам.
#nullable disable

Random rnd = new Random();
int n = rnd.Next(1, 10);
string[] startArray = new string[n];
int count = 0;

while (startArray.Length != count)
{
    Console.Write($"Input {count + 1} word of {startArray.Length} words: ");
    string newWord = Console.ReadLine();
    startArray[count] = newWord;
    count ++;
}
Console.Write("A primary array: [");
Console.Write(string.Join(", ", startArray));
Console.WriteLine("]");

int sumWords = 0;
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        sumWords ++;
    }
}

string[] finishArray = new string[sumWords];
int countfin = 0;
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        finishArray[countfin] = startArray[i];
        countfin ++;
    }
}

Console.Write("A finish array: [");
Console.Write(string.Join(", ", finishArray));
Console.WriteLine("]");