/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1)*/

//using System.Linq;
Console.Clear();

int m = SettArray("Введите количество строк: ");
int n = SettArray("Введите количество столбцов: ");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
SortArray(array);


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
    int[] sum = new int[m];
    int min = 0;
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            sum[i] += matrixArr[i, j];
        }
        if (sum[min] > sum[i]) min = i;
    }
    Console.WriteLine($"Наименьшая сумма : {sum[min]} в строке: {min + 1}");
    //Console.WriteLine(sum.Min());
}
