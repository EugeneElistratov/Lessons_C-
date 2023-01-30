// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] GenerateArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write($"[ {array[0]:f1}"); // выводит на печать первый элемент массива без запятой
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]:f1}"); //выводит на печать остальные элементы массива с  запятой впереди
    }
}

double DiffMaxMin(double[] array) // разница между максимальным и минимальным элементов массива
{
    double FindMin(double[] array, double Min, int i = 0)
    {
        if (i >= array.Length) return Min;
        return FindMin(array, Min > array[i] ? array[i] : Min, i + 1);
    }
    double FindMax(double[] array, double Max, int i = 0)
    {
        if (i >= array.Length) return Max;
        return FindMax(array, Max < array[i] ? array[i] : Max, i + 1);// ?: тернарный оператор, 
             // возвращает одно из двух значений. Если Мах < array, будет array[i], иначе Мах.
    }
    return FindMax(array, array[0]) - FindMin(array, array[0]);
}

double[] array = GenerateArray(5);
PrintArray(array);
Console.Write($"] -> {DiffMaxMin(array):f1}");
Console.Write(" -- разница между максимальным и минимальным элементами массива.");

