// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Пример:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] numbers = new double [8];
array1(numbers);
Console.WriteLine();
delta(numbers);

void array1 (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 99);
        Console.Write($"{arr[i]} ");
    }
}

void delta (double [] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    
    }
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    double delta = max - min;
    Console.WriteLine($"Разница между максимальным {max} и минимальнфм {min} составляет: {delta}");
}