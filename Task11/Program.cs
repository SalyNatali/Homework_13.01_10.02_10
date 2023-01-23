// 11. Напишите программу, которая 
// 1) выводит случайное трёхзначное число и 
// 2) удаляет вторую цифру этого числа. 

// 456 -> 46 
// 782 -> 72 
// 918 -> 98

int RandomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Конечное число => {RandomNumber}");
int finishNumber = GetNumber(RandomNumber);
Console.WriteLine($"Конечное число => {finishNumber}");

int GetNumber(int number)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;

    int result = firstNumber * 10 + secondNumber;
    return result;
}
