// Напишите программу, которая 
// 1) принимает на вход координаты двух точек и
// 2) находит расстояние между ними в 2D пространстве.

// Например:
// А (з, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance (x1, y1, x2, y2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.Write($"Расстояние между точками {distanceRound}");

double Distance (int xa1, int ya1, int xa2, int ya2)
{
    return Math.Sqrt(Math.Pow((xa2 - xa1), 2) + Math.Pow((ya2 - ya1), 2));
}

