// Напишите программу, которая 
// 1) принимает на вход число N и
// 2) выдаёт произведение чисел от 1 до N.

// Пример:
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int value = Factorial(num);
if(num <= 0) Console.WriteLine("Некорректный ввод");
else Console.WriteLine($"{num} -> {value}");

int Factorial(int number)
{
    int result = 1;
    int counter = 1;
    while (counter <= number)
    {
        result *= counter;
        counter++;
    }
    return result;
}
