using System.Diagnostics.CodeAnalysis;

int num = int.Parse(Console.ReadLine());



PrintSecondPartOfTriangle(num);


static void PrintSecondPartOfTriangle(int num)
{

    for (int i = 1; i < num; i++)
    {
        PrintFirstPartOfTriange(1, i);
    }
    for (int i = num; i >= 1; i--)
    {
        PrintFirstPartOfTriange(1, i);

    }

}
static void PrintFirstPartOfTriange(int start, int end)
{

    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();

}