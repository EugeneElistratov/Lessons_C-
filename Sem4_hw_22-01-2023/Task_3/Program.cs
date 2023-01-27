// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. Оформите заполнение массива и вывод 
// в виде функции (пригодится в следующих задачах).  Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

Console.Clear();
int Prompt(string message)
{
    System.Console.Write($"{message}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] CreateArray(int x)         // вызвать CreateArray массив с размером  х
{
    int InputMin = Prompt("Введите минимальный порог случайных значений");
    int InputMax = Prompt("Введите максимальный порог случайных значений");
    int[] array = new int[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(InputMin, InputMax);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}, ");
    }
}
int x = Prompt($"Задайте размер массива");
void ReturnArray(int[] array)
{
    System.Console.Write(" -> ");
    for (int k = 0; k < array.Length; k++)
    {
        Console.Write($"{array[k]}, ");
    }
    System.Console.WriteLine("");
}
int[] array = CreateArray(x);  //  функция CreateArray прячет  массив в переменную  array

ShowArray(array); // показывает массив
ReturnArray(array); // возвращает массив 