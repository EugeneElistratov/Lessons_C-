// Задача 2. Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double b1 = Prompt("Введите число b1 ");
double k1 = Prompt("Введите число k1 ");
double b2 = Prompt("Введите число b2 ");
double k2 = Prompt("Введите число k2 ");

if (k1 == k2) Console.WriteLine("Прямые параллельны и точек пересечения нет.");
else
{
    double CrossPointX = ((b2 - b1) / (k1 - k2));
    double x = CrossPointX;
    double CrossPointY = k1 * CrossPointX + b1;
    double y = CrossPointY;
    System.Console.WriteLine($"{x:f1}, {y:f1} -> Точка пересечения двух прямых");
}
