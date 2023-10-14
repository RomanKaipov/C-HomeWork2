// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string msg)
{
    Console.WriteLine("Enter number: ");
    string a = Console.ReadLine();
    int num = int.Parse(a);
    return num;
}

bool checkNumber(int number)
{
    if (number > 0 && number < 7)
    {
        return true;
    }
    Console.WriteLine("This not day of the week");
    return false;
}


bool weekend(int number)
{
    if (number > 5)
    {
        return true;
    }
    return false;
}

int num = ReadInt("Enter number");
if (checkNumber(num))
{
    if (weekend(num))
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}



