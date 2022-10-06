/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

Console.Write("Укажите размер массива: ");
int arrLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrLength];
SettArray(array);
PrintArray(array);
Console.WriteLine($"Количество четных элементов: {QuanS(array)}");

void SettArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int QuanS(int[] array)
{
    int count = 0;
    for (int i = 0; i < arrLength; i++)
    {
        if (array[i] % 2 == 0)
            count++;

    }
    return count;
}