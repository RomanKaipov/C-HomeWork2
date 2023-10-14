// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int number;
    number = int.Parse(a);
    return number;
}
int num = ReadInt("Enter number > 99 and number < 1000: ");
Console.WriteLine($"Second character of the number {num} is equal to {num / 10 % 10}");