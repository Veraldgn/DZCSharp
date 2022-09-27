/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();

Console.Write("Введите координату X для A: ");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для A: ");
double ya = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z для A: ");
double za = double.Parse(Console.ReadLine()!);

Console.Write("Введите координату X для B: ");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для B: ");
double yb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z для B: ");
double zb = double.Parse(Console.ReadLine()!);

double dist = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));

Console.Write(dist.ToString("#.00"));