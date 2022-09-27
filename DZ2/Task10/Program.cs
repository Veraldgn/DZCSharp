/* Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа. */

Console.Clear();

Console.WriteLine("Введите  число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"num = {num / 10 % 10}");