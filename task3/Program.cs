// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void IsHoliday(int arg)
{
    if (arg > 5) Console.Write($"{arg} -> да");
    else Console.Write($"{arg} -> нет");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int day = GetInfo("Введите цифру от 1 до 7: ");
IsHoliday(day);
