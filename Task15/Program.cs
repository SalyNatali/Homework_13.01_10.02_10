// Задача 15: Напишите программу, которая 
// 1) принимает на вход цифру, обозначающую день недели, и  
// 2) проверяет, является ли этот день выходным.

Console.Write("Введите обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    Console.WriteLine(Square(day) ? "Выходной" : "Рабочий");
    bool Square (int day)
    {
        return day < 8 && day > 5;
    }
}
else
{
    Console.WriteLine($"Дня недели под цифрой {day} нет");
}


