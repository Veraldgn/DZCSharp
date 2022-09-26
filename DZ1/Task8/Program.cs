/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. */

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
// count - счётчик, 2 - первое чётное число
int count = 2; 

if(num <= 1)
{
    Console.Write("Недействующий диапозон  ");
}

while(count <= num)
{
    Console.Write($"{count} ");
    count += 2;
}
