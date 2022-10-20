// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int m = SettArray("Введите количество строк первой матрицы: ");
int n = SettArray("Введите количество столбцов первой матрицы: ");
int a = SettArray("Введите количество строк второй матрицы: ");
int b = SettArray("Введите количество столбцов второй матрицы: ");
int[,] arrayOne = new int[m, n];
int[,] arrayTwo = new int[a, b];
if (n != a)
{
    Console.WriteLine("Кол-во столбцов первой матрицы должно быть равным кол-ву строк второй матрицы!!!");
}
else
{
    FillArray(arrayOne);
    FillArray(arrayTwo);
    PrintArray(arrayOne);
    Console.WriteLine();
    PrintArray(arrayTwo);
    Console.WriteLine();
    PrintArray(MultiMatrix(arrayOne, arrayTwo));
}

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
            matrixArr[i, j] = random.Next(0, 10);
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

int[,] MultiMatrix(int[,] matrixArrOne, int[,] matrixArrTwo)
{
    int[,] multiMat = new int[matrixArrOne.GetLength(0), matrixArrTwo.GetLength(1)];
    for (int i = 0; i < matrixArrOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArrTwo.GetLength(0); j++)
        {
            for (int z = 0; z < matrixArrTwo.GetLength(1); z++)
            {
                multiMat[i, z] += matrixArrOne[i, j] * matrixArrTwo[j, z];
            }

        }
    }
    return multiMat;
}