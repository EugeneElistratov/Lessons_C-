// Задача 1: Задайте двумерный массив. Напишите программу,
//  которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int PromptInt(string mess)
{
    System.Console.Write($"{mess} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
            {
                if (matrix[i, n] < matrix[i, n + 1])
                {
                    int temp = matrix[i, n];
                    matrix[i, n] = matrix[i, n + 1];
                    matrix[i, n + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int m = PromptInt("Введите количество строк массива: ");
int n = PromptInt("Введите количество столбцов массива: ");
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
SortMaxToMin(matrix);
PrintMatrix(matrix);

