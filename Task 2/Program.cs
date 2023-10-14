// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int number = int.Parse(a);
    return number;
}

int Character(int number)
{
    while (number>999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool checkNumber(int number)
{
    if (number < 100)
{
    Console.WriteLine("Number < 100!");
    return false;
}
return true;
}

int num = ReadInt("Enter number: ");
if (checkNumber(num))
{
    Console.WriteLine(Character(num));
}


