/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();

int n = ParseStrToInt("Введите N: ");
if (n >= 1) NatureNum(n);
else Console.WriteLine("Введите натуральное число больше 1");



void NatureNum(int num)
{
    if (num < 1) return;
    Console.Write($"{num} ");
    NatureNum(num - 1);
}


int ParseStrToInt(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}



