/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine()!;
if (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
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