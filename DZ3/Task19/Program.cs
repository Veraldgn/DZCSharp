/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
string drom = Console.ReadLine()!;
if (drom.Length == 5)
{
    if (drom[0] == drom[4] && drom[1] == drom[3])
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число");
} 


//другое решение задачи




Console.WriteLine("Введите пятизначное число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int one = num / 10000 % 10;
int two = num / 1000 % 10;
int four = num / 10 % 10;
int five = num % 10;

if (num < 10000 || num > 100000)
{
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число");
}
else if (one == five && two == four)
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}