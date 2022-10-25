/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int m = ParseStrToInt("Введите M: ");
int n = ParseStrToInt("Введите N: ");

int Akk = Akkerman(m, n);
if (Akk == -1) Environment.Exit(0);
else Console.WriteLine($"A({m}, {n}) = {Akk}");


int Akkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numM > 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }
    if (numM > 0 && numN > 0)
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    }
    if (numM < 0 || numN < 0)
    {
        Console.WriteLine("Числа должны быть положительными");
        return -1;
    }
    return Akkerman(numN, numM);

}

int ParseStrToInt(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
