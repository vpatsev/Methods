string type = Console.ReadLine();

GetGreaterOfTwoValues(type);
static void GetGreaterOfTwoValues(string type) //тук може и с static string ...
{

    switch (type)
    {
        case "int":
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else { Console.WriteLine(num2); }
            break;

        case "string":
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (string.Compare(str1, str2) > 0)
            {
                Console.WriteLine(str1);
            }
            else
            {
                Console.WriteLine(str2);
            }
            break;
        case "char":
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            if (char1 < char2) { Console.WriteLine(char2); }
            else { Console.WriteLine(char1); }
            break;

    } //return type;
}

