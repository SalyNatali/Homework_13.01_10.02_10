// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] numbers = new int [8];
array1 (numbers);
Console.WriteLine();
amount (numbers);

void array1 (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-999,999);
        Console.Write($"{arr[i]} ");
    }
}
void amount (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr [i];
    }
    Console.WriteLine($"Сумма чисел на нечётных позициях: {sum}");
}