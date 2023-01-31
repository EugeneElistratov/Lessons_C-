// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] UserArray(string message)
{
    Console.Write(message);
    char[] SplitChar = new char[] { ' ', ',' }; // Массив символов разделителей
    return Array.ConvertAll(Console.ReadLine().Split(SplitChar,
    StringSplitOptions.RemoveEmptyEntries), int.Parse); // удаляет повторяющийся 
                                                        // ввод пробелов и запятых, и преобразует в 32-битовое целое число со знаком
}
int Prompt(string message)
{
    System.Console.Write($"{message}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int M = Prompt("Задайте размер массива М =");

int FindPositiveNums(int[] array) // количество положительных чисел
{
    int count = 0;
    for (int i = 0; i < M; i++)
        {
        if (array[i] > 0) count++;
        }
            {
        return count;
            }
}
void PrintArray(int[] array)
{
    Console.Write($" {array[0]}"); // выводит на печать первый элемент массива без запятой
    for (int i = 1; i < M; i++)
    {
        Console.Write($", {array[i]}");// печать остальных чисел
    }
}

int[] UserNum = UserArray("Введите числа через пробел и запятую и нажмите Enter -> ");
PrintArray(UserNum); // выводит на печать массив с запятыми и пробелами
Console.Write($" -> Положительных чисел: {FindPositiveNums(UserNum)}");
