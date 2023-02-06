// Задача 4: 
//Напишите программу, которая заполнит спирально квадратный массив.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($" {matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SpiralOutput(int size)
{
    int value = 1;
    int i = 0, j = 0;
    int[,] matrix = new int[size, size];
    while (size != 0)
    {
        int k = 0;
        do { matrix[i, j++] = value++; } while (++k < size - 1);
        // Заполняем первую строку до столбца [индекс 3].
        for (k = 0; k < size - 1; k++) matrix[i++, j] = value++;
        // Заполняем 4 столбец до 4 строки. 
        for (k = 0; k < size - 1; k++) matrix[i, j--] = value++;
        // Заполняем 4 строку от 4 до 1 столбца.    
        for (k = 0; k < size - 1; k++) matrix[i--, j] = value++;
        // Заполняем 1 столбец от 4 до 2 строки. 
        ++i; ++j; size = size < 2 ? 0 : size - 2;
        // ++i - Префиксный оператор инкремента, возвращает уже 1+i
        // Если size < 2, то size = 0, иначе = size-2
    }
    PrintMatrix(matrix);
}

int size = 4;
SpiralOutput(size);
