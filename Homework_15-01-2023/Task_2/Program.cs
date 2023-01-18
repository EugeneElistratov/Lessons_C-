/*
Задача 2: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int InputInt(string massege)
{
    Console.WriteLine(massege);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputInt("Введите целое число");

if (a < 100) System.Console.WriteLine($"{a}  -->  Третьей цифры нет");

else
{
    while (a > 1000)
    {
        a = a / 10;
    }
    a = a % 10;
    System.Console.WriteLine($"Третья цифра  --> {a}");
}