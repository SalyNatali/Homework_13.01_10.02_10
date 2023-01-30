//  Задача 25: Напишите цикл, который 
// 1) принимает на вход два числа (A и B) и 
// 2) возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
for (int i = 1; i < b; i++)
{
    res *= a;
}
Console.Write(res);