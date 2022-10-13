/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.Clear();

double b1 = SettArray("Введите b1: ");
double k1 = SettArray("Введите k1: ");
double b2 = SettArray("Введите b2: ");
double k2 = SettArray("Введите k2: ");
SectLine();

double SettArray(string mes)
{
    Console.Write(mes);
    double num = double.Parse(Console.ReadLine()!);
    return num;
}
void SectLine()
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Точка пересечения: {x}, {y}");
}