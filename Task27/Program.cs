// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// Пример:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;

while (num > 0)
{
    res = res + num % 10;
    num = num / 10;
}
Console.Write(res);
