// Напишите программу, которая
// 1) принимает на вход число (N) и
// 2) выдаёт таблицу квадратов чисел от 1 до N.

// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите натурально число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);

 // while (n <= number)
// {
//    Console.WriteLine($"{n} {n*n}");
//    n++;
// }

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} {count*count}");
        count++;
    }
}