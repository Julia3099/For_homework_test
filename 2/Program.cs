/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
String number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
System.Console.Write("Введите второе число: ");
String number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
System.Console.Write("Введите третье число: ");
String number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);
int max = a;
if (b > max)
{
    max = b;
    if (c > max)
    {
        Console.Write($"Число {c} максимальное");
    }
    else Console.Write($"Число {b} максимальное");
}
else if (c > max)
{
    max = c;
    Console.Write($"Число {c} максимальное");
}
else Console.Write($"Число {a} максимальное");