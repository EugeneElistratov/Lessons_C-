// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] Matrix = new int[m, n];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(min, max);
        }
    }
    return Matrix;
}

void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write($"{Matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.Write("Среднее арифметическое каждого столбца: ");
}

double[] ColumnAverage(int[,] Matrix)
{
    double[] Array = new double[Matrix.GetLongLength(1)];
    for (int i = 0; i < Matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < Matrix.GetLength(0); j++)
        {
            sum += Matrix[j, i];
        }
        Array[i] = sum / Matrix.GetLength(0);
        Console.Write($"{Array[i]}; ");
    }
    return Array;
}

int[,] Matrix = CreateMatrix(4, 4, 0, 9);
PrintMatrix(Matrix);
double[] Average = ColumnAverage(Matrix);


