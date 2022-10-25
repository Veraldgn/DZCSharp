/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N. 
Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int m = ParseStrToInt("Введите M: ");
int n = ParseStrToInt("Введите N: ");
if (m < n) Console.WriteLine($"Сумма: {NaturSum(m, n)}");
else Console.WriteLine("М должна быть меньше N");


int NaturSum(int numM, int numN)
{
    int summ = 0;
    if (numM <= numN)
    {
        summ = numM + NaturSum(numM + 1, numN);

    }
    return summ;
}

int ParseStrToInt(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
