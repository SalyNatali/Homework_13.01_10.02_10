// 16. Напишите программу, которая 
// 1) принимает на вход два числа и 
// 2) проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да 
// 25, 5  ->  да 
// 8,9  ->  нет

bool Square(int number1, int number2)
{
    return ((number1 * number1 == number2)) || ((number2 * number2 == number1));
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

if (result == true)Console.WriteLine("да");
else Console.WriteLine("нет");
