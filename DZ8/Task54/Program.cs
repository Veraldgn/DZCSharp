/*  Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();

int m = SettArray("Введите количество строк: ");
int n = SettArray("Введите количество столбцов: ");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);

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

void SortArray(int[,] matrixArr)
{
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            for (int z = 0; z < matrixArr.GetLength(1); z++)
            {
                if (matrixArr[i, j] >= matrixArr[i, z])
                {
                    int temp = matrixArr[i, j];
                    matrixArr[i, j] = matrixArr[i, z];
                    matrixArr[i, z] = temp;
                }
            }
        }
    }
}