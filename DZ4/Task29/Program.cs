/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


void SettArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(-50, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Clear();
int[] array = new int[8];
SettArray(array);
PrintArray(array);