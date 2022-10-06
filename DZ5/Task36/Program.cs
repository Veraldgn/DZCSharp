/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.Clear();

Console.Write("Укажите размер массива: ");
int arrLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrLength];
SettArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов нечетных индексов: {SumM(array)}");

void SettArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = random.Next(0, 500);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int SumM(int[] array)
{
    int sum = 0;
    for (int i = 1; i < arrLength; i += 2)
    {
        sum += array[i];
    }
    return sum;
}