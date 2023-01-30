// Задача 1: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write($"[ {array[0]}"); // выводит на печать первых элемент массива без запятой
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}"); //выводит на печать остальные элементы массива с  запятой впереди
    }
}
int FindChetn(int[] array) // количество чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
int[] array = GenerateArray(4);
PrintArray(array);

Console.Write($"] -> {FindChetn(array)} -- количество чётных чисел в массиве.");
