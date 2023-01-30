// Задача 29: Напишите программу, которая 
// 1) задаёт массив из 8 элементов и 
// 2) выводит их на экран.

// Пример:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int [8];
Random rnd = new Random();
void Random (int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = rnd.Next(0, 99);
        Console.Write(arr[i] + " ");
    }
}
Random(array);