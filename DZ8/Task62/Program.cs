/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.Clear();

int m = SettArray("Введите количество строк: ");
int n = SettArray("Введите количество столбцов: ");
int[,] array = new int[m, n];
SpiralMatrix(array);
PrintArray(array);

int SettArray(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void SpiralMatrix(int[,] matrixArr)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matrixArr.GetLength(0) * matrixArr.GetLength(1))
    {
        matrixArr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrixArr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrixArr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrixArr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] matrixArr)
{
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"|0{matrixArr[i, j]}| ");
            }
            else
            {
                Console.Write($"|{matrixArr[i, j]}| ");
            }
        }
        Console.WriteLine();
    }
}