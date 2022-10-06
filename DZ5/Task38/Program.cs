/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();

Console.Write("Укажите размер массива: ");
int arrLength = int.Parse(Console.ReadLine()!);
double[] array = new double[arrLength];
SettArray(array);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами: {Diff(array)}");

void SettArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10, 2);
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine($"[{String.Join("; ", array)}]");
}

double Diff(double[] array)
{
    int max = 0;
    int min = 0;
    for (int i = 1; i < arrLength; i++)
    {
        if (array[i] > array[max]) max = i;
        if (array[i] < array[min]) min = i;
    }
    return Math.Round(array[max] - array[min], 2);
}