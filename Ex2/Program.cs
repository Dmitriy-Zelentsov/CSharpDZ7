// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет

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

void FindElement(int[,] arr)
{
    Console.WriteLine("Введите индекс элемента m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс элемента n");
    int n = Convert.ToInt32(Console.ReadLine());
    if ((m < 0 || m >= arr.GetLength(0)) || (n < 0 || n >= arr.GetLength(1)))
    {
        Console.WriteLine("Элемента с введенными индеками нет в массиве");
    }
    else
    {
        Console.WriteLine(arr[m, n]);
    }
}

int[,] array = CreateMatrix(5, 3, 1, 100);
PrintMatrix(array);
Console.WriteLine();
FindElement(array);
