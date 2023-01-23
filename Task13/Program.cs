// Задача 13: Напишите программу, которая 
// 1) выводит третью цифру заданного числа или 
// 2) сообщает, что третьей цифры нет.

// Например:
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
int result = num % 10;
Console.Write(result);
}
else
Console.Write("Третьей цифры нет");


