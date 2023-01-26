// Задача 21. Напишите программу, которая
// 1) принимает на вход координаты двух точек и 
// 2) находит расстояние между ними в 3D пространстве.

// Пример:
// А (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53

Console.WriteLine("Координаты точки A");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты точки B");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}
double distance = Distance(x1, y1, z1, x2, y2, z2);
double distanceRound = Math.Round(distance, 2);
Console.WriteLine("Расстояние между точками А и B в 3D пространстве: " + distanceRound);

