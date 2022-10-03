/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();

Console.Write("Введите первое число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
int result = Power(num1, num2);
Console.WriteLine(result);

int Power(int a, int b)
{
    int res = a;
    for(int i = 1; i < b; i++)
    {
        res *= num1;
    }
    return res;
}
