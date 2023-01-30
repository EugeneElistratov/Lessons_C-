// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-19, 20);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write($"[ {array[0]}"); // выводит на печать первый элемент массива без запятой
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}"); //выводит на печать остальные элементы массива с запятой впереди 
    }
}
int SumNechet(int[] array) // сумма нечётных элементов
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int[] array = GenerateArray(4);
PrintArray(array);
Console.Write($"] -> {SumNechet(array)}  сумма элементов, стоящих на нечётных позициях.");
