/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num = Prompt("Введите число");

int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

System.Console.WriteLine($"Сумма цифр в числе {num} > {SumNumbers(num)}");