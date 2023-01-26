// Напишите программу, которая 
// 1) принимает на вход число (N) и
// 2) выдаёт таблицу кубов чисел от 1 до N.

// Пример:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Не корректный ввод");
else Table(n);
void Table (int number)
{
    int count = 1;
    Console.WriteLine("Таблица кубов от 1 до N: ");
    while(count <= number)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
}
