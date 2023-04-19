// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество колонок");
int[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);
Console.Write("Введите номер строки: ");
int coordinate1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int coordinate2 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine();
if (coordinate1 < 0 | coordinate1 > arr.GetLength(0) - 1 | coordinate2 < 0 | coordinate2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[coordinate1, coordinate2]);
}
Console.ReadLine();