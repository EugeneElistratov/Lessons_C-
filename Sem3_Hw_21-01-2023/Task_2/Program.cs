// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}
double x1 = Prompt("Введите координаты x1 ");
double y1 = Prompt("Введите координаты y1 ");
double z1 = Prompt("Введите координаты z1 ");
double x2 = Prompt("Введите координаты x2 ");
double y2 = Prompt("Введите координаты y2 ");
double z2 = Prompt("Введите координаты z2 ");

double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double a; 
    double b; 
    double c;
    a = x2 - x1;
    b = y2 - y1;
    c = z2 - z1;
    return Math.Sqrt(a*a + b*b + c*c); 
}
System.Console.WriteLine(Distance( x1, x2, y1, y2, z1, z2 ));
