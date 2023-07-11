// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetTwoDigit(int arg)
{
    int twodigit = (arg/10)%10;
    return twodigit;
}

int GetInfo(string arg)
{
    Console.Write(arg);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int number = GetInfo("Введите трехзначное число: ");
Console.Write($"{number} -> {GetTwoDigit(number)}");