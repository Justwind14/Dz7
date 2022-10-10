// Zadacha47();
// Zadacha50();
Zadacha52();

void Zadacha47()
{
    // Задача 47. Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.

    Console.Clear();
    Console.Write("Введите количество строк в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    FillArray(array);
    PrintArray(array);
   
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-100, 100) * 0.17;
        }
    }
}


void Zadacha50()
{
    // Задача 50. Напишите программу, которая на вход принимает
    // позиции элемента в двумерном массиве, и возвращает
    // значение этого элемента или же указание, что такого элемента нет.

    Console.Clear();

    Random random = new Random();
    int rows = random.Next(1, 11);
    int columns = random.Next(1, 11);
    int[,] arrayNew = new int[rows, columns];
    FillArrayInt(arrayNew);
    PrintArrayNew(arrayNew);
    ElementValue(arrayNew, rows, columns);
   
}
void FillArrayInt(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-10, 11);
        }
    }
}

void PrintArrayNew(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void ElementValue(int[,] arr, int rows, int columns)
{
     Console.Write("Введите индекс строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < rows & j < columns)
    { Console.WriteLine(arr[i, j]); }
    else { Console.WriteLine("Элемента с такой позицией в массиве нет!"); }
}



void Zadacha52()
{
    // Задача 52. Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом столбце.

    Console.Clear();

    Random random = new Random();
    int rows = random.Next(2, 9);
    int columns = random.Next(2, 9);
    int[,] array = new int[rows, columns];
    FillArrayInt(array);
    PrintArrayNew(array);
    AverageElementArray(array);
}
void AverageElementArray(int[,] arr)
{
    double rowsSize = arr.GetLength(0);
    int columnsSize = arr.GetLength(1);
    for (int iColumns = 0; iColumns < columnsSize; iColumns++)
    {
        double sumColumnsElement = 0;
        double сolumnsAverage = 0;
        for (int iRows = 0; iRows < rowsSize; iRows++)
        {
            sumColumnsElement = sumColumnsElement + arr[iRows, iColumns];
        }
        сolumnsAverage = sumColumnsElement / rowsSize;
        Console.WriteLine($"Среднее арифметическое элементов {iColumns + 1}го столбца :  {Math.Round(сolumnsAverage, 2)}");
    }
}