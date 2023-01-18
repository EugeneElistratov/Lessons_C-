/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int InputTnt(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InputTnt("Введите трёхзначное число");
if (a > 99 && a < 1000)
{
    int result = a % 10;
    int second = ((a - result) / 10) % 10;

    Console.WriteLine("Вторая цифра числа равна " + second);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}