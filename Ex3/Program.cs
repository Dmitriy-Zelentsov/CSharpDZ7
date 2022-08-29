// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

void FindESum(int[,] arr)
{
    double sr_result = 0;
    double sum = 0;
    for (int row = 0; row < arr.GetLength(1); row++)
    {
        for (int column = 0; column < arr.GetLength(0); column++)
        {
            sum += arr [column, row];
            sr_result = sum /arr.GetLength(0);
        }
        Console.WriteLine($"Среднее арифметическое {row+1} столбца = {sr_result}");
        sum=0;
    }
}

int[,] array = CreateMatrix(5, 3, 1, 2);
PrintMatrix(array);
Console.WriteLine();
FindESum(array);

