/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). */

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if(num % 2 == 0)
{
    Console.WriteLine("чётное");
} 
else
{
    Console.WriteLine("нечётное");
}