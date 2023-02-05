// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindRowSum(int[,] arr)
{
    int[] FindRowSum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            FindRowSum[i] += arr[i, j];
        }
    }
    return FindRowSum;
}

int FindIndexMinSumOfRows(int[] arr)
{
    int min = arr[0];
    int indexMin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin + 1;
}

int[,] massiv = new int[2, 3];
FillArray(massiv);
PrintArray(massiv);
//PrintMatrix(RectangularMatrix);
int[] sumOfRows = FindRowSum(massiv);
int minIndex = FindIndexMinSumOfRows(sumOfRows);
Console.WriteLine($"Наименьшая сумма элементов в: {minIndex} строке");
