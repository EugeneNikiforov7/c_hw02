// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetThirdDigit(int arg)
{
    while (arg > 999) 
    {
        arg = arg / 10;
    }
 
    return arg % 10;
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetInfo("Введите число: ");
if (number < 100) 
{
    Console.Write($"{number} -> третьей цифры нет");
}
else 
{
    Console.Write($"{number} -> {GetThirdDigit(number)}");
}