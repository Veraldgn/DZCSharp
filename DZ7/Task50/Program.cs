/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив
1 4 7 2
5 9 2 3
8 4 2 4
1
7 -> такого числа в массиве нет */
Console.Clear();


int m = SettArray("Введите количество строк: ");
int n = SettArray("Введите количество столбцов: ");
int row = SettArray("Введите индекс строки: ");
int column = SettArray("Введите индекс столбца: ");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
FindEl(array, row, column);

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
            matrixArr[i, j] = random.Next(0, 100);
        }
    }
}

void FindEl(int[,] matrixArr, int r, int c)
{
    if (r > matrixArr.GetLength(0) - 1 || c > matrixArr.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента не существует");
    }
    else
        Console.WriteLine(matrixArr[r, c]);
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