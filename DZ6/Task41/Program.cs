/* Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
5 0 7 8 -2 -2 -> 2
5 1 -7 567 89 223-> 3 */
Console.Clear();

Console.Write("Укажите размер массива: ");
int arrLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrLength];
SettArray(array);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0: {PosQuan(array)}");

void SettArray(int[] array)
{

    for (int i = 0; i < arrLength; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine()!);

    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int PosQuan(int[] array)
{
    int count = 0;
    for (int i = 0; i < arrLength; i++)
    {
        if (array[i] > 0)
            count++;

    }
    return count;
}