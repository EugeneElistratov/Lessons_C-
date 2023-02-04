// Задача 2. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int Prompt(string message)
{
    System.Console.Write($"{message}");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);

int k = Prompt("Введите номер строки: ");
if ( k > 4 || k < 1)
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else
{
    int l = Prompt("Введите номер столбца: ");
    if (l > 4 || l < 1)
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
    else
    {
        System.Console.WriteLine($"Значение = {matrix[k - 1, l - 1]}  ");
    }
}

