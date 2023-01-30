// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример:
// [345, 897, 568, 234] -> 2

int [] numbers = new int [5];
array (numbers);
Console.WriteLine();
evennum (numbers);

void array (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
        Console.Write($"{arr[i]} ");
    }
}
void evennum (int [] nums)
{
    int result = 0;
    foreach (int number in numbers)
    {
        if ((number % 2) < 1)
        {
            result ++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {result}");
}