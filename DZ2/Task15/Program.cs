/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.Clear();

Console.WriteLine("Введите  число: ");
int numDay = int.Parse(Console.ReadLine()) - 1;

int[] days = { 1, 2, 3, 4, 5, 6, 7 };

if (numDay >= 0 && numDay < 7)
{
    if (days[numDay] > 5)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Рабочий день");
}
else
    Console.WriteLine("Нет такого дня");
