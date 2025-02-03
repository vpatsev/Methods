using System.ComponentModel;

int baseNum  = int.Parse(Console.ReadLine());
int power  = int.Parse(Console.ReadLine());

Console.WriteLine(PowerTwoNums(baseNum,power));

static double PowerTwoNums(int baseNum,int power )
{
    double result = Math.Pow(baseNum, power);
    return result;
}