﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num * num;

Console.Write($"Квадрат числа {num2}");
