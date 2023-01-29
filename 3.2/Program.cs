/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Prompt("Введите координату x1 для первой точки");
int y1 = Prompt("Введите координату y1 для первой точки");
int z1 = Prompt("Введите координату z1 для первой точки");
int x2 = Prompt("Введите координату x2 для второй точки");
int y2 = Prompt("Введите координату y2 для второй точки");
int z2 = Prompt("Введите координату z2 для второй точки");

double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
double a = 0.0;
double b = 0.0;
double c = 0.0;
a = x2 - x1;
b = y2 - y1;
c = z2 - z1;

return Math.Sqrt(a * a + b * b + c * c);
}

Double sqrt = Distance(x1, x2, y1, y2, z1, z2);
System.Console.WriteLine($"Расстояние между точками с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round(sqrt, 2)}");
