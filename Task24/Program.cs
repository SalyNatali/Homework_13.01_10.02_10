// Напишите программу, которая 
// 1) принимает на вход число (А) и
// 2) выдаёт сумму чисел от 1 до А.

// Пример:
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int sumNumbers = SumNumbers(number);
    Console.Write($"Сумма чисел от 1 до {number} = {SumNumbers(number)}");
}
else
Console.Write("Введено некорректное значение");


int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        // sum = sum + i;
        sum += i;
    }
    return sum;
}

