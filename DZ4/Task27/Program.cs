/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Sum(int number)
{
    int digit = 0;
    while(number > 0)
    {
        digit += number % 10;
        number /= 10;
    }
    return digit;
}

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = Sum(num);
Console.WriteLine($"Сумма цифр = {result}");