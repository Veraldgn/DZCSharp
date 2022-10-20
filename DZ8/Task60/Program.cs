/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

int m = SettArray("Введите количество строк: ");
int n = SettArray("Введите количество столбцов: ");
int z = SettArray("Введите глубину: ");
int[,,] array = new int[m, n, z];
FillArray(array);
PrintArray(array);

int SettArray(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FillArray(int[,,] matrixArr)
{
    string[] arr = new string[matrixArr.GetLength(0) * matrixArr.GetLength(1) * matrixArr.GetLength(2)];
    int count = 0;
    Random random = new Random();

    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            for (int k = 0; k < matrixArr.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(10, 100);
                while (arr.Contains(Convert.ToString(array[i, j, k])))
                    array[i, j, i] = random.Next(10, 100);
                arr[count] = Convert.ToString(array[i, j, k]);
                count++;
            }
        }
    }
}

void PrintArray(int[,,] matrixArr)
{
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}
