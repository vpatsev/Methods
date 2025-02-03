//int width = int.Parse(Console.ReadLine());
//int length = int.Parse(Console.ReadLine());

//CalculateArea(width, length);

//static void CalculateArea(int width,int length) {
//    int area = width * length;
//    Console.WriteLine(area);
//}



using System.Reflection.Metadata.Ecma335;

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateArea(width,length));

static int CalculateArea(int width, int length)
{
    int area = width * length;
    return area;
}