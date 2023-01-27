/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
String number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
System.Console.Write("Введите второе число: ");
String number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
if (a > b)
{
    Console.Write($"max = {a}");
}
if (a < b)
{
    Console.Write($"max = {b}");
}
else Console.Write("Максимального нет. Вы ввели одинаковые числа");