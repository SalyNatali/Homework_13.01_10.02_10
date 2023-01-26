// Напишите программу, которая 
// 1) принимает на вход пятизначное число и
// 2) проверяет, является ли оно палиндромом.

// Например:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999)
{
    int a = num / 10000;
    int b = num % 10;
    int c = (num / 1000) - (num / 10000) * 10;
    int d = num % 100 / 10;
    if (a == b && c == d)
    {
        Console.WriteLine("является палиндромом");
    }
    else
    Console.WriteLine("не является палиндромом");
}
else
Console.WriteLine("Не корректный ввод");

