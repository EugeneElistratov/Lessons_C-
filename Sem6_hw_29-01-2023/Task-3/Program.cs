// Задача 5: Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. Затем найдите минимальное значение 
// по каждой колонке, получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму (с минимумами).
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] Matrix = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } };// Двумерный массив.

void PrintMatrix(int[,] Matrix) // Печать массива.
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumMaxArray(int[,] Matrix) // Сумма максимумов по каждой строке.
{
    int sum = 0;
    for (int j = 0; j < Matrix.GetLength(0); j++) // Пока j < количества строк в матрице.
    {
        int max = Matrix[j, 0];
        for (int i = 0; i < Matrix.GetLength(1); i++) // Пока i < количества столбцов в матрице.
        {
            if (max < Matrix[j, i])
            {
                max = Matrix[j, i];
            }
        }
        sum += max;
    }
    return sum;
}

int SumMinArray(int[,] Matrix) // Сумма минимумов по каждой колонке.
{
    int sum = 0;
    for (int j = 0; j < Matrix.GetLength(1); j++) // Пока j < количества столбцов в матрице.
    {
        int min = Matrix[0, j];
        for (int i = 0; i < Matrix.GetLength(0); i++) // Пока i < количества строк в матрице.
        {
            if (min > Matrix[i, j])
            {
                min = Matrix[i, j];
            }
        }
        sum += min;
    }
    return sum;
}

int DiffMaxMin(int[,] Matrix) //  Разница max и min.
{
    return SumMaxArray(Matrix) - SumMinArray(Matrix);
}

PrintMatrix(Matrix);
Console.WriteLine("Сумма максимумов по каждой строке = " + SumMaxArray(Matrix));
Console.WriteLine("Сумма минимумов по каждой колонке = " + SumMinArray(Matrix));
Console.WriteLine("Разница max и min = " + DiffMaxMin(Matrix));

