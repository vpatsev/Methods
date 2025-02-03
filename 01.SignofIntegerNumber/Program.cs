int number = int.Parse(Console.ReadLine()); 
 ReadsIntegerNumber(number);
static void ReadsIntegerNumber(int number)
{
    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}