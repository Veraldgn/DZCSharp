/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();


int m = SettArray("Введите количество строк: ");
int n = SettArray("Введите количество столбцов: ");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
ArifMean(array);

int SettArray(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FillArray(int[,] matrixArr)
{
    Random random = new Random();
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            matrixArr[i, j] = random.Next(0, 50);
        }
    }
}

void PrintArray(int[,] matrixArr)
{
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            Console.Write($"|{matrixArr[i, j]}| ");
        }
        Console.WriteLine();
    }
}

void ArifMean(int[,] matrixArr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0;  i < matrixArr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrixArr.GetLength(0); j++)
        {
            sum += matrixArr[j, i];
        }
        Console.Write($"|{Math.Round(sum / matrixArr.GetLength(0), 1)}| ");
    }
}