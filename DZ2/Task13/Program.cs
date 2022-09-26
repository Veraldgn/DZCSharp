// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите  число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()));

if (num < 100)
    Console.Write("Третьей цифры нет");
else
{
    while (num > 999)
    {
        num = num / 10;
    }

    num = num % 10;
    Console.Write($" -> {num % 10}");
}



