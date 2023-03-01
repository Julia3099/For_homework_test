/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    if (start % 2 == 0)
    {
        System.Console.Write(start + " ");
        ShowNumbers(start + 2, finish);
    }
    else
    {
        start += 1;
        System.Console.Write(start + " ");
        ShowNumbers(start + 2, finish);
    }

}

int number1 = Prompt("Введите первое число (левую границу промежутка)");
int number2 = Prompt("Введите второе число (правую границу промежутка)");
System.Console.WriteLine();
System.Console.Write($"Получаем последовательность чётных элементов из промежутка ({number1}, {number2})> ");
ShowNumbers(number1, number2);